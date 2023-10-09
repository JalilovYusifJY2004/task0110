using System.Text;

namespace task01102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task4
            //Console.WriteLine("text daxil et");
            //string text = Console.ReadLine();

            //Console.WriteLine("simvol daxil et");
            //char symbol = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //Console.WriteLine("tam text");
            //Console.WriteLine(Trim(text,symbol));

            // task1 
          //string name = Console.ReadLine(); 
          //  Console.WriteLine(name);
          //  Capitalize(name);


        }
        // Task 1
        //public static string Capitalize(string str)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(Char.ToUpper(str[0]));
        //    for (int i = 1; i < str.Length; i++)
        //    {
        //        sb.Append( Char.ToLower(str[i]));  
        //    }
        //    return sb.ToString();
        //}
        // task4
        //public static string TrimStart(string text, char symbol = ' ')
        //{
        //    int count = 0;
        //    string newtext = "";
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == symbol)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            count=i; break;
        //        }
        //    }
        //    for (int i = count;i < text.Length; i++)
        //    {
        //        newtext+= text[i];
        //    }
        //    return newtext;
        //}
        //public static string TrimEnd(string text,char symbol = ' ')
        //{
        //    int last= text.Length-1;
        //    string newtext = "";
        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        if (text[i]==symbol)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            last= i; break; 
        //        }
        //    }
        //    for (int i = 0; i <= last; i++)
        //    {
        //        newtext += text[i];
        //    }
        //    return newtext;
        //}
        //public static string Trim(string text,char symbol = ' ') 
        //{ 
        //    string newtext = TrimStart(text,symbol);
        //    newtext = TrimEnd(newtext,symbol);
        //    return newtext;
        //}
    }

}