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
            if (_int_N %  2 ==0)
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

            // b) Kiểm tra các ngoại lệ khi nhập điểm:
            //Không nhập gì.
            //Nhập điểm âm
            //Nhập quá phạm vi 0 đến 10.
            //Nhập chữ
            Console.WriteLine("Bai tap 1: Nhap thong tin sinh vien:");
            string _Hoten_KQ = NhapDiem();
            Console.WriteLine("Xin chao ban " + _Hoten_KQ);
            Console.ReadLine();
        }
        private static string NhapDiem()
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
                            NhapDiem();
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Khong duoc nhap so vao ho ten!");
                        NhapDiem();
                    }    
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban!");
                NhapDiem();
            }
            //if (string.IsNullOrEmpty(_HoTen) && string.IsNullOrWhiteSpace(_HoTen)) //Cách 2: Kiểm tra rỗng
            //{

            //}
            return "";

        }
    }
}
