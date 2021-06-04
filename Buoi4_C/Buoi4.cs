using System;

namespace Buoi4_C
{
    class Buoi4
    {
        static void Main() //Mặc định định khi chạy sẽ chạy vào Main() trước
        {
            //Function (Phương thức)
            //Phương thức 1 chiều:
            //Cấu trúc: Static void + [Tên phương thức]() {[Lệnh cần làm]}
            //VÍ DỤ: 
            //NghiemVu1();
            //Phương thức 2 chiều (Function);
            //Cấu trúc: Static + Kiểu dữ liệu đầu ra + [Tên phương thức]() {[Lệnh cần làm]}
            //VÍ DỤ:
            //int _KetQuaNhanVe = NghiemVu2();
            //Console.WriteLine("Ket qua tra ra là 4+5= {0}",_KetQuaNhanVe);
            //Console.ReadLine();
            //Phương thức 2 chiều có kèm theo(Function);
            //Cấu trúc: stactic + Kiểu dữ liệu đầu ra + [Tên phương thức]([Kiểu dữ liệu đầu] vào TenBienKemtheo) {[Lệnh cần làm]}
            //VÍ DỤ:
            string _KetQuaNhanVe = NghiemVu3(5,6);
            Console.WriteLine("Ket qua tra ra là {0}", _KetQuaNhanVe);
            Console.ReadLine();
        }
        static void NghiemVu1()//Phương thức 1 chiều:
        {
            Console.WriteLine("Day la nghiem vu 1");
            Console.ReadLine();
        }
        static int NghiemVu2()//Phương thức 2 chiều (Function);
        {
            int _KetQuaDauRa = 0;//Tạo biến đầu ra và khởi tạo biến
            _KetQuaDauRa = 4 + 5;
            return _KetQuaDauRa;//Trả lại kết quả
        }
        static string NghiemVu3(int _BienKemTheo) //Phương thức 2 chiều có kèm theo(Function);
        {
            string _KetQuaDauRa = "";
            if (_BienKemTheo % 2 == 0)
            {
                _KetQuaDauRa = "Chan";
            }
            else
            {
                _KetQuaDauRa = "Le";
            }
            return _KetQuaDauRa;
        }
        static string NghiemVu3(int _BienKemTheo1, int _BienKemTheo2) //Phương thức 2 chiều có kèm theo(Function);
        {
            int _KetQuaDauRa = 0;//Tạo biến đầu ra và khởi tạo biến
            _KetQuaDauRa = 4 + 5;
            return Convert.ToString(_KetQuaDauRa);//Trả lại kết quả
        }
    }
}
