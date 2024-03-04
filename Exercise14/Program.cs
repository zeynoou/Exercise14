namespace Exercise14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers of your plays:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Convert.ToInt32(b);
            var result3 = Convert.ToInt32(c);
            var result4 = CountPoints(result1, result2, result3);
            Console.WriteLine("Your points of plays is:" + result4);
        }

        public static int CountPoints(int wins, int draws, int losses)
        {
            int total = (wins * 3) + (draws * 1) + (losses * 0);
            return total;
        }
    }

}
