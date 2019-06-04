// author: Chris Patton
// summary: Self-made program with a char[] that defines and 
// RETURNS THE REVERSE OF A STRING declared in the main method.
// notes: created a holder char[] to hold the reverse char[] results
// student: Chris Patton

    class Program
    {
        public char[] ReverseString(string testString)
        {
            char[] chars = testString.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0, j = testString.Length - 1; i < testString.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            string testString = "this is a test string";
            char[] result = program.ReverseString(testString);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
