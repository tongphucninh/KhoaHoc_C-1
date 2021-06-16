using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi7_C
{
    class Tongphucninh0383476596
    {
        public void Test_class()
        {
            Console.WriteLine("Bai tap : ");

            string _Hoten_KQ = Nhapten();
            Console.WriteLine("Xin chao ban " + _Hoten_KQ);
            double _Diemtoan = NhapDiem("toan");
            double _Diemly = NhapDiem("ly");
            double _Diemhoa = NhapDiem("hoa");
            double _DTB = (_Diemhoa + _Diemtoan + _Diemly) / 3;
            string _HocLuc = Danhgiahocluc(_DTB);

            Console.WriteLine("================HOC SINH===================");
            Console.Write("{0,-20}|", "Ho Va Ten");
            Console.Write("{0,-5}|", "Hoa");
            Console.Write("{0,-5}|", "Toan");
            Console.Write("{0,-5}|", "Ly");
            Console.Write("{0,-5}|", "DTB");
            Console.WriteLine("{0,-10}|", "Hoc luc");
            Console.Write("{0,-20}|", _Hoten_KQ);
            Console.Write("{0,-5}|", _Diemhoa);
            Console.Write("{0,-5}|", _Diemtoan);
            Console.Write("{0,-5}|", _Diemly);
            Console.Write("{0,-5}|", _DTB);
            Console.Write("{0,-5}|", _HocLuc);
            Console.ReadLine();
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
            if (string.IsNullOrEmpty(_HoTen) && string.IsNullOrWhiteSpace(_HoTen))
            {

            }
            return "";

        }
        static double NhapDiem(string _Tenmonhoc)
        {
            double _dlb_Diem = 0.0;
            Console.Write("Diem mon {0} cua ban la :", _Tenmonhoc);
            string _str_diem = Console.ReadLine();
            if (_str_diem != "" && _str_diem != " ")
            {
                if (char.IsNumber(_str_diem, 0))
                {
                    _dlb_Diem = double.Parse(_str_diem);
                    if (_dlb_Diem >= 0)
                    {
                        if (_dlb_Diem <= 10)
                        {
                            return _dlb_Diem;

                        }
                        else
                        {
                            Console.WriteLine("Diem khong hop ly!");
                            NhapDiem(_Tenmonhoc);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so duong!");
                        NhapDiem(_Tenmonhoc);
                    }
                }
                else
                {
                    Console.WriteLine("Ban phai nhap so!");
                    NhapDiem(_Tenmonhoc);
                }
            }
            else
            {
                Console.WriteLine("ban chua nhap diem");
                NhapDiem(_Tenmonhoc);

            }
            return _dlb_Diem;
        }
        static string Danhgiahocluc(double _DTB)
        {
            string _Hocluc = "";
            if (_DTB >= 0 && _DTB < 5)
            {
                _Hocluc = "Trung Binh";
            }
            else if (_DTB >= 5 && _DTB < 7)
            {
                _Hocluc = "Kha";

            }
            else if (_DTB >= 7 && _DTB < 10)
            {
                _Hocluc = "Gioi";
            }
            return _Hocluc;
        }
    }
}
