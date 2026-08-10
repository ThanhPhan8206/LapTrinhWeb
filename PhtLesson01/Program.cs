using System.Security.Cryptography;
using System.Text;

namespace PhtLesson01;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        System.Console.WriteLine("Phan Hữu Thành");
        System.Console.WriteLine("Sinh ngày : 8/2/2006");
        System.Console.WriteLine("Giới tính : NAM");
        
        // Gọi hàm từ file khác bằng cú pháp: TênClass.TênHàm();
        ThongTin.InThongTinKhac();
    }
}