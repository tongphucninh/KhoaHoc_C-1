using System;

namespace Buoi6_C
{
    class Buoi6
    {
        //Cách khai báo biến toàn cục
        static int[,] m_mang_int ;
        static void Main()
        {
            //Lý thuyết
            //Phan6_1();
            //Phan6_2();
            //Phan6_3();
            //Phan6_4();
            Phan6_5();
        }
        static void Phan6_1()
        {
            //Mảng 1 chiều
            //Kiểu_dữ_liệu[] Tên_mảng = new Kiểu_dữ_liệu[Số giá trị] {A1,A2,A3,…A số giá trị}
            //Ví dụ
            string[] _mang_str = new string[3] { "Phan tu1", "Phan tu2", "Phan tu3" };
            Console.Write(_mang_str[1]);
            Console.ReadLine();
        }
        static void Phan6_2()
        {
            //Mảng 2 chiều
            //Kiểu_dữ_liệu[,] Tên_mảng = new Kiểu_dữ_liệu[Số hàng, số cột] {{A11,A12,..},{A21,A22,..},...}
            m_mang_int = new int[3, 4] { { 3, 54, 8, 3 }, { 4,5,6,7}, { 8,9,10,11} };
            /*Console.Write(_mang_int[1, 2]);
            Console.ReadLine();*/
        }
        static void Phan6_3()
        {
            Phan6_2();
            // Gọi phần 6.2 để khởi tạo mảng 2 chiều
            //For
            /*for ([Khởi_tạo]; [Điều_kiện];[Bước_lặp])
            {
                < Khối lệnh >
            }*/
            
            for (int i = 0;i<4;i++)
            {
                Console.Write("{0}\t", m_mang_int[0 , i]);
            }
            Console.ReadLine();
        }

        static int[] m_int = new int[5] { 4, 1, 6, 2, 8 };
        static void Phan6_4()
        {
            //for each
            foreach (int _int_tam in m_int)
            {
                Console.Write("{0}\t", _int_tam);
            }
            Console.ReadLine();
        }  
        static void Phan6_5()
        {
            //Mảng đa chiều không cố định
            //trong đó int[] là kiểu dữ liệu
            int[][] _mang2_int =
            {
                new int[] {1,2,3},
                new int[] {4,3,5,2,6},
                new int[] {2,3,7,8,5,8}
            };
            
            //In ra màn hình mảng 2 chiều
            //Sử dụng 2 vòng for 
            foreach (int[] _mang_int_tam in _mang2_int)
            {
                foreach (int _int_tam in _mang_int_tam)
                {
                    Console.Write("{0}\t", _int_tam);
                }

                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
