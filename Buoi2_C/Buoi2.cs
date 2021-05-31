using System;
namespace Buoi2_C
{
    class Buoi2
    {
        static void Main()
        {
            //Phan1_1();
            //Phan1_2();
            Phan1_3();
        }
        static void Phan1_1()
        {
            //Buổi 2: Biến, Hằng và các toán.
            //Các in ra màn hình: Ví dụ: "Chao mung den trung tam lap trinh spec"
            //Console.Write("Chao mung den trung tam lap trinh spec");
            //Console.ReadLine();

            //Khai báo biến
            //<Kiểu dữ liệu> _Tenbien  [=Gán giá trị];
            string _str = "abc";
            int _int1 = 2;
            int _int2 = 2;
            double _dou = 2.2;
            //TH1: In chuỗi
            Console.WriteLine("Chuoi vua khai bao: " + _str);
            //TH2: In số thực, số nguyên
            Console.WriteLine("so vua khai bao: {0} và {1}", _int1, _dou);
            Console.ReadLine();
        }
        static void Phan1_2()
        {
            //Nhập và đọc chuỗi vừa nhập vào màn hình.
            Console.Write("Ho và ten cua ban la gi? Ten minh là: ");
            string _HoTen = Console.ReadLine();
            Console.Write("Xin chao ban " + _HoTen + "\n");
            Console.Write("So ky tu trong ten cua ban la: {0}\n", _HoTen.Length);
            Console.Write("ho ten in thuong: {0}\n", _HoTen.ToLower());
            Console.Write("HO TEN IN HOA: {0}\n", _HoTen.ToUpper());
            Console.Write("Kiem tra co chu T: {0}", _HoTen.Contains("T"));
            Console.ReadLine();
        }
        static void Phan1_3()
        {
            //Toán tử
            Console.Write("Moi nhap so nguyen can kiem tra, N = ");
            string _str_SoNguyen = Console.ReadLine(); //Đọc ký tự mà mình vừa ghi ra màn hình.
            int _int_SoNguyen = Convert.ToInt32(_str_SoNguyen); //chuyển kiểu biến từ chuỗi sang số nguyên.
            //Toán tử 3 ngôi:
            //a) Kiểm tra chẵn lẻ
            string _KetQua_A = (_int_SoNguyen % 2 != 0) ? "So le":"So chan";
            Console.WriteLine("a) So \"N\" = {0} la {1}", _int_SoNguyen, _KetQua_A);
            //b) Kiểm tra âm dương
            string _KetQua_B = (_int_SoNguyen >= 0) ? "So duong" : "So am";
            Console.WriteLine("b) So N = {0} la {1}", _int_SoNguyen, _KetQua_B);
            Console.ReadLine();
        }
    }
}
