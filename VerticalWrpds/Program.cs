namespace VerticalWrpds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string words = Console.ReadLine();
            char[] result = words.ToCharArray();
            Console.WriteLine(string.Join("\n",result));
        }
    }
}
