using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Double chieuDai, chieuRong, chuVi, dienTich;
           
            do
            {
                try
                {
                    Console.WriteLine("MỜI BẠN NHẬP CHIỀU DÀI: ");
                    chieuDai = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("MỜI BẠN NHẬP CHIỀU RỘNG: ");
                    chieuRong = Convert.ToInt32(Console.ReadLine());
                    chuVi = (chieuDai + chieuRong) * 2;
                    Console.WriteLine($"CHU VI HÌNH CHỮ NHẬT LÀ: {chuVi}");
                    dienTich = chieuDai * chieuRong;
                    Console.WriteLine($"DIỆN TÍCH HÌNH CHỮ NHẬT LÀ: {dienTich}");
                    Console.WriteLine($"CẠNH NHỎ NHẤT LÀ:  " + Math.Min(chuVi,dienTich));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("ĐÃ CÓ LỖI VUI LÒNG NHẬP LẠI!!!");
                }
            } while (true);
           
            Console.ReadKey();  
        }
    }
}
