using System;

namespace KhoaHoc_C
{
    class Program
    {
        static void Main()
        {
            //Phan1_1();
            Phan1_2();
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
        //Cấu trúc: static void TenFunction(){Vùng code;}
        static void Phan1_2()
        {
            //Nhập và đọc chuỗi vừa nhập vào màn hình.
            Console.Write("Ho và ten cua ban la gi? Ten minh là: ");
            string _HoTen = Console.ReadLine();
            Console.Write("Xin chao ban " + _HoTen + "\n");
            Console.Write("So ky tu trong ten cua ban la: {0}\n", _HoTen.Length);
            Console.Write("ho ten in thuong: {0}\n", _HoTen.ToLower());
            Console.Write("HO TEN IN HOA: {0}\n", _HoTen.ToUpper());
            Console.Write("Kiem tra co chu T: {0}", _HoTen.Contains("Tuan"));
            Console.ReadLine();

        }
    }
}
