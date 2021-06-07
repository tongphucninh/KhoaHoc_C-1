using System;
namespace Buoi3_C
{
    class Buoi3
    {
        static void Main()
        {
            //Phan1();
            //Phan2();
            BaiTap();
        }
        public static void Phan1()
        {
            //1:Kiểu dữ liệu
            Console.Write("\' \"  \\ \0  \a  \b");
            Console.ReadLine();
            //2:Ép kiểu dữ liệu
            //2.1. Ép kiểu ngầm định
            short x = 10;
            int y = x;
            //2.2. Ép kiểu tường mình
            int a = 256;
            double b = (double)a;
            //string c = (string) b; KHÔNG ĐƯỢC
            //2.3 Phương thức Parse
            string _str = "10";
            int _int = int.Parse(_str);//NHỚ
            Console.ReadLine();
        }
        static void Phan2()
        {
            //Cấu trúc điều kiện.
            //Ví dụ 2.1:
            Console.WriteLine("Ví dụ 2.1:");
            Console.Write("So nguyen can kiem tra là, N = ");
            string _str_N = Console.ReadLine();
            int _int_N = int.Parse(_str_N);
            string _KetQua_A = "";
            //a
            if (_int_N % 2 == 0)
            {
                _KetQua_A = "So chan";
            }
            else if (_int_N % 2 != 0)
            {
                _KetQua_A = "So le";
            }
            Console.WriteLine("N là " + _KetQua_A);

            //b
            string _KetQua_B = "";
            if (_int_N < 0)
            {
                _KetQua_B = "So am";
            }
            else if (_int_N >= 0)
            {
                _KetQua_B = "So duong";
            }
            Console.WriteLine("N là " + _KetQua_B);
            Console.ReadLine();

        }
        static void BaiTap()
        {
            //Yêu cầu sử dụng lệnh điều kiện If else:
            // a) Kiểm tra các ngoại lệ khi nhập tên
            //Không nhập gì.
            //Nhâp số
            //Nhập quá ngắn.
            //Nhập quá dài.

            //b) Kiểm tra các ngoại lệ khi nhập điểm:
            //Không nhập gì.
            //Kiểm tra nó là số hay không
            //Nhập điểm âm
            //Nhập quá phạm vi 0 đến 10.
            Console.WriteLine("Bai tap 1: Nhap thong tin sinh vien:");
            string _Hoten_KQ = Nhapten();
            double _DiemToan = NhapDiem("toán");
            double _DiemLy = NhapDiem("lý");
            double _DiemHoa = NhapDiem("hóa");
            double _DTB = Math.Round((_DiemHoa + _DiemToan + _DiemLy) / 3,2);
            string _HocLuc = DanhGiaHocLuc(_DTB);
            //In ra dạng bảng
            Console.WriteLine("=======================HOC SINH=============================");
            //Tên cột
            Console.Write("{0,-20}|","Ho va ten");
            Console.Write("{0,-5}|", "Hoa");
            Console.Write("{0,-5}|", "Toan");
            Console.Write("{0,-5}|", "Ly");
            Console.Write("{0,-5}|", "DTB");
            Console.WriteLine("{0,-10}", "Hoc luc");
            //In Kết quả
            Console.Write("{0,-20}|", _Hoten_KQ);
            Console.Write("{0,-5}|", _DiemHoa);
            Console.Write("{0,-5}|", _DiemToan);
            Console.Write("{0,-5}|", _DiemLy);
            Console.Write("{0,-5}|", _DTB);
            Console.Write("{0,-10}", _HocLuc);
            Console.ReadLine();
        }
        static string Nhapten()
        {
            Console.Write("Ho ten cua ban la: ");
            string _HoTen = Console.ReadLine();
            if (_HoTen != "" && _HoTen != " ")  //Cách 1: Kiểm tra rỗng
            {
                    if (!char.IsNumber(_HoTen,0)) //Kiểm tra nó là số hay không
                    {
                        if (_HoTen.Length >3) //Kiểm tra nhập quá ngắn
                        {
                            return _HoTen;
                        }
                        else
                        {
                            Console.WriteLine("Ho ten cua ban qua ngan!");
                            Nhapten();
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Khong duoc nhap so vao ho ten!");
                    Nhapten();
                    }    
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban!");
                Nhapten();
            }
            //if (string.IsNullOrEmpty(_HoTen) && string.IsNullOrWhiteSpace(_HoTen)) //Cách 2: Kiểm tra rỗng
            //{

            //}
            return "";

        }
        static double NhapDiem(string _TenMonHoc)
        {
            double _dbl_Diem = 0.0;
            Console.Write("diem mon {0} cua ban la: ", _TenMonHoc);
            string _str_Diem = Console.ReadLine();
            if (_str_Diem != "" && _str_Diem != " ")//DK1: Kiểm tra rỗng
            {
                if (char.IsNumber(_str_Diem,0))//DK2: Kiem tra la so hay không
                {
                    _dbl_Diem = double.Parse(_str_Diem);
                    if (_dbl_Diem >=0) //DK3: Kiểm tra nhâp số âm
                    {
                        if(_dbl_Diem <=10) //DK4: Nhap diem qua to
                        {
                            return _dbl_Diem;
                        }
                        else
                        {
                            Console.WriteLine("Diem khong hop ly!");
                            return NhapDiem(_TenMonHoc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so duong!");
                        return NhapDiem(_TenMonHoc);
                    }
                }
                else 
                {
                    Console.WriteLine("Ban phai nhap so!");
                    return NhapDiem(_TenMonHoc);
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap diem!");
                return NhapDiem(_TenMonHoc);
            }    
            //return _dbl_Diem;
        }
        static string DanhGiaHocLuc(double _DTB)
        {
            string _HocLuc = "";
            if (_DTB >=0 && _DTB <5)
            {
                _HocLuc = "Trung binh";
            }    
            else if (_DTB >=5 && _DTB <7)
            {
                _HocLuc = "Kha";

            }
            else if(_DTB >= 7 && _DTB <= 10)
            {
                _HocLuc = "Gioi";
            }
            return _HocLuc;
        }       
        //
    }
}
