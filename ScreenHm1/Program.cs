class Program
{
    static void Main()
    {
        bool start = true;
        while (start)
        {
            Console.WriteLine("1 -- screen\n2 -- exit");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                if (!Directory.Exists(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Image"))
                    Directory.CreateDirectory(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\imagel");

                Bitmap png = new Bitmap(1080, 900);
                Graphics g = Graphics.FromImage(png);
                g.CopyFromScreen(0, 0, 0, 0, size: png.Size);
                Guid i = Guid.NewGuid();
                string fileName = string.Format($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Imagel" + @$"\Image  {i}" + ".png");
                png.Save(fileName);
                Console.WriteLine("successful");
            }
            else if (a == 2)
            {
                start = false;
                Environment.Exit(0);
            }
        }
    }
}