namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "My name is rutuja";


            for (int i = s.Length - 1; i >= 0; i--) 
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
