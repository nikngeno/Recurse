namespace Recurse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(First("Nicholas"));
            Console.WriteLine();
            Console.WriteLine(Rest1("Nicholas"));
            Console.WriteLine();
            Console.WriteLine(Rest("Nicholas"));
            Console.WriteLine();
            Console.WriteLine(Length("Nicholas"));
            Console.WriteLine();
            WriteString("Nicholas");
            WriteBackward("Nicholas");
            ReverseString("Monday Morning");
        }
        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }

        public static string Rest1(string s)
        {
            char first = s[0];
            return first.ToString();
        }
        // rest: returns a new string that contains all but the
        // first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }
        
        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }
           
        
        static void WriteString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();
        }

        static void WriteBackward(string s)
        {
            for (int i = s.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();
        }

        static string ReverseString(string s)
        {
            for(int i = s.Length - 1 ; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            return s;
        
        }
    }
}
