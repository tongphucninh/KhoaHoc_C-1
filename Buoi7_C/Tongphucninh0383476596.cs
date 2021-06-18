using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi7_C
{
    class Tongphucninh0383476596
    {
        public  void Class()
        {
            List<string[]> _inraman = new List<string[]>();
            string[] _mang_ten = { "STT", "Ho va Ten", "Diem Toan", "Diem Ly", "Diem Hoa", "DTB", "Hoc Luc" };
            _inraman.Add(_mang_ten);
            string _KiemTra = "Y";
            int i = 1;
            while (_KiemTra == "Y")
            {
                string _Hoten_KQ = Nhapten();
                double _DiemToan = NhapDiem("Toan");
                double _DiemLy = NhapDiem("Ly");
                double _DiemHoa = NhapDiem("Hoa");
                Console.WriteLine("Diem  toan cua ban la: {0}đ", _DiemToan);
                Console.WriteLine("Diem  ly cua ban la: {0}đ", _DiemLy);
                Console.WriteLine("Diem hoa cua ban la: {0}đ", _DiemHoa);
                double _DTB = Math.Round((_DiemHoa + _DiemToan + _DiemLy) / 3, 2);
                string _HocLuc = DanhGiaHocLuc(_DTB);
                string[] _mang_data =
                {
                   i.ToString(), _Hoten_KQ, _DiemToan.ToString(), _DiemLy.ToString(), _DiemHoa.ToString(), _DTB.ToString(), _HocLuc
                };
                _inraman.Add(_mang_data);
                Console.Write("Ban muon tiep tuc hay k (Y/N): ");
                _KiemTra = Console.ReadLine().ToUpper();

                i++;
            }
            foreach (string[] _item in _inraman)
            {
                Console.Write("{0,-5}", _item[0]);
                Console.Write("{0,-35}", _item[1]);
                Console.Write("{0,-10}", _item[2]);
                Console.Write("{0,-10}", _item[3]);
                Console.Write("{0,-10}", _item[4]);
                Console.Write("{0,-10}", _item[5]);
                Console.Write("{0,-10} \n", _item[6]);
            }

            Console.ReadKey();          

        }
        static string Nhapten()
        {
            Console.Write("Ho ten cua ban la: ");
            string _HoTen = Console.ReadLine();
            if (_HoTen != "" && _HoTen != " ")
            {
                if (!char.IsNumber(_HoTen, 0))
                {
                    if (_HoTen.Length > 3)
                    {
                        return _HoTen;
                    }
                    else
                    {
                        Console.WriteLine("Ho ten cua ban qua ngan!");
                        return Nhapten();
                    }
                }
                else
                {
                    Console.WriteLine("Khong duoc nhap so vao ho ten!");
                    return Nhapten();
                }
            }
            else

            {
                Console.WriteLine("Ban chua nhap ho ten cua ban!");
                return Nhapten();
            }
            return "";

        }
        static double NhapDiem(string _TenMonHoc)
        {
            double _dbl_Diem = 0.0;
            Console.Write("diem mon {0} cua ban la: ", _TenMonHoc);
            string _str_Diem = Console.ReadLine();
            if (_str_Diem != "" && _str_Diem != " ")
            {
                if (char.IsNumber(_str_Diem, 0))
                {
                    _dbl_Diem = double.Parse(_str_Diem);
                    if (_dbl_Diem >= 0)
                    {
                        if (_dbl_Diem <= 10)
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
            return _dbl_Diem;
        }
        static string DanhGiaHocLuc(double _DTB)
        {
            string _HocLuc = "";
            if (_DTB >= 0 && _DTB < 5)
            {
                _HocLuc = "Trung binh";
            }
            else if (_DTB >= 5 && _DTB < 7)
            {
                _HocLuc = "Kha";

            }
            else if (_DTB >= 7 && _DTB <= 10)
            {
                _HocLuc = "Gioi";
            }
            return _HocLuc;
        }
    }
}
