namespace SortingTechniques1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String s = "ABC";
            String answer = "";
            Console.Write("\nAll possible strings are : ");
            PermutationOfStringUsingRecursiveApproach.RecursiveApproach(s, answer);

        }
    }
}

