namespace SortingTechniques
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String str = "DOG";
            int n = str.Length;
            Console.Write("\nAll possible strings are : ");
            PermutationOfString.usingIterativeMethod(str, 0, n - 1);
        }
    }
}
