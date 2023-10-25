using System.Linq;
using System.Text;


namespace bolygok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<naprendszer> bolygok = new List<naprendszer>();

            using (var sr = new StreamReader(@"..\..\..\src\solsys.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new naprendszer(sr.ReadLine()));
                }
            }

            

            Console.WriteLine($"A naprendszerben {bolygok.Count()} bolygo van");

         
            Console.WriteLine($"A naprendszerben a bolygoknak atlagosan{1}holdja van");
            Console.WriteLine($"A legnaygobb terfogatu bolygo a {1}");
            Console.Write("Írd be a keresett bolygó nevét: ");
            var bolygonev = Console.ReadLine();
            if (bolygonev != bolygok)
            {
                Console.WriteLine("");
            }
        }
    }
}