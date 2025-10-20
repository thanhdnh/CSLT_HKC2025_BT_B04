using System.Net.WebSockets;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        /*
        //Bài 10 (Tuần tự)
        double tiengui, tienlanh; 
        byte thoigian;
        float laisuat;
        Console.WriteLine(" Nhap so tien gui");
        tiengui = double.Parse(Console.ReadLine());
        Console.WriteLine(" Nhap thoi gian gui");
        thoigian = byte.Parse(Console.ReadLine());
        Console.WriteLine(" Nhap lai suat");
        laisuat = float.Parse(Console.ReadLine());
        tienlanh = tiengui + (tiengui * laisuat * thoigian);
        Console.WriteLine(" so tien lanh duoc la: {0}", tienlanh);
        
        Console.WriteLine("Nhap vao so nguyen duong");
        int a = int.Parse(Console.ReadLine());
        if (a < 0) Console.WriteLine("Khong phai so nguyen duong");
        else if (a % 3 == 0 && a % 5 == 0) 
                Console.WriteLine($"{a} la boi so cua 3 va 5");
        else
            Console.WriteLine($"{a} khong phai la boi cua 3 va 5");
        */
        /*
        double ketqua = 0;
        Console.WriteLine("Nhap phep toan (+,-,*,/, can bac 2): ");
        string PhepToan = Console.ReadLine();
        if (PhepToan == "can bac 2")
        {
            Console.Write("Nhap toan hang: ");
            double ToanHang = double.Parse(Console.ReadLine());
            ketqua = Math.Sqrt(ToanHang);
        }
        else
        {
            Console.Write("Nhap toan hang 1: ");
            double ToanTu1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap toan hang 2: ");
            double ToanTu2 = double.Parse(Console.ReadLine());
            if (PhepToan == "+") ketqua = ToanTu1 + ToanTu2;
            else if (PhepToan == "-") ketqua = ToanTu1 - ToanTu2;
            else if (PhepToan == "*") ketqua = ToanTu1 * ToanTu2;
            else if (PhepToan == "/") ketqua = ToanTu1 / ToanTu2;
        }
        Console.WriteLine("Ket qua la: " + ketqua);
        */
        /*
        Console.WriteLine("Nhap nam sinh cua nam:");
        uint a= uint.Parse(Console.ReadLine());
        Console.WriteLine("Nhap nam sinh cua nu:");
        uint b = uint.Parse(Console.ReadLine());
        string tenchinam = "", tenchinu = "";

        if (a < 1900 || b < 1900)
        {
            Console.WriteLine("Nam sinh khong hop le"); 
        }
        uint chi1= (a - 1900) % 12;
        uint chi2 = (b - 1900) % 12;

        switch (chi1)
        {
            case 0:
                tenchinam = "Ty";
                break;
            case 1:
                tenchinam = "Suu";
                break;
            case 2:
                tenchinam = "Dan";
                break;
            case 3:
                tenchinam = "Mao";
                break;
            case 4:
                tenchinam = "Thin";
                break;
            case 5:
                tenchinam = "Ty";
                break;
            case 6:
                tenchinam = "Ngo";
                break;
            case 7:
                tenchinam = "Mui";
                break;
            case 8:
                tenchinam = "Than";
                break;
            case 9:
                tenchinam = "Dau";
                break;
            case 10:
                tenchinam = "Tuat";
                break;
            case 11:
                tenchinam = "Hoi";
                break;
        }
        switch (chi2)
        {
            case 0:
                tenchinu = "Ty";
                break;
            case 1:
                tenchinu = "Suu";
                break;
            case 2:
                tenchinu = "Dan";
                break;
            case 3:
                tenchinu = "Mao";
                break;
            case 4:
                tenchinu = "Thin";
                break;
            case 5:
                tenchinu = "Ty";
                break;
            case 6:
                tenchinu = "Ngo";
                break;
            case 7:
                tenchinu = "Mui";
                break;
            case 8:
                tenchinu = "Than";
                break;
            case 9:
                tenchinu = "Dau";
                break;
            case 10:
                tenchinu = "Tuat";
                break;
            case 11:
                tenchinu = "Hoi";
                break;
        }

        if (tenchinam == "Dan" || tenchinam == "Than" || tenchinam == "Ty" || tenchinam == "Hoi")
        {
            if (tenchinu == "Dan" || tenchinu == "Than" || tenchinu == "Ty" || tenchinu == "Hoi")
                Console.WriteLine("Hai nguoi ky tuoi nhau");
            else
                Console.WriteLine("Hai nguoi khong ky tuoi nhau");
        }
        else if (tenchinam == "Thin" || tenchinam == "Tuat" || tenchinam == "Suu" || tenchinam == "Mui")
        {
            if (tenchinu == "Thin" || tenchinu == "Tuat" || tenchinu == "Suu" || tenchinu == "Mui")
                Console.WriteLine("Hai nguoi ky tuoi nhau");
            else
                Console.WriteLine("Hai nguoi khong ky tuoi nhau");
        }
        else if (tenchinam == "Ty" || tenchinam == "Ngo" || tenchinam == "Meo" || tenchinam == "Dau")
        {
            if (tenchinu == "Ty" || tenchinu == "Ngo" || tenchinu == "Meo" || tenchinu == "Dau")
                Console.WriteLine("Hai nguoi ky tuoi nhau");
            else
                Console.WriteLine("Hai nguoi khong ky tuoi nhau");
        }
        */
        /*
        Console.Write("Nhap 4 so: ");
        double so1 = double.Parse(Console.ReadLine());
        double so2 = double.Parse(Console.ReadLine());
        double so3 = double.Parse(Console.ReadLine());
        double so4 = double.Parse(Console.ReadLine());
        double total = so1 + so2 + so3 + so4;
        double tich = so1 * so2 * so3 * so4;
        double max = Math.Max(Math.Max(so1, so2), Math.Max(so3, so4));
        double min = Math.Min(Math.Min(so1, so2), Math.Min(so3, so4));
        double s1 = total - max - min;
        double s2 = tich / (max * min);
        double delta = Math.Pow(s1, 2) - 4 * s2;
        double x = (s1 + Math.Sqrt(delta) ) / 2;
        double y = (s1 - Math.Sqrt(delta)) / 2;
        double mmax = Math.Max(x, y);
        double mmin = Math.Min(x, y);

        Console.WriteLine($"Sorted:  {max}, {mmax}, {mmin},  {min}");
        */
        Console.Write("Nhap vao so nguyen thu nhat: ");
        int so1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so nguyen thu hai: ");
        int so2 = int.Parse(Console.ReadLine());
        int tempa = so1;
        int tempb = so2;
        while (tempa != 0)
        {
            int r = tempa % tempb;
            tempa = tempb;
            tempb = r;
        }
        int ucln = (so1 * so2) / tempa;
        Console.Write("BCNN la {0}, UCLN la {1}", tempa, ucln);
    }
}