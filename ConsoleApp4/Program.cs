namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //üçgenin alanı değerler 
            Console.Write("kenar:");
            string a = Console.ReadLine();
            int knr = Convert.ToInt32(a);
            Console.Write("yükseklik:");
            string y= Console.ReadLine();
            int yks= Convert.ToInt32(y);
            double alan = knr * yks / 2;
            Console.WriteLine("üçgenini alanı:" + alan);
        }
    }
}
