using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp4
{
    public class DisplayDocuments
    {
        public static void DisplayAdditionPage()
        {
            string directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileAdditonPage = directory + @"\AdditionPage.txt";


            try
            {

                using (StreamReader outputAdditionPage = new StreamReader(fileAdditonPage))
                {
                    fileAdditonPage = outputAdditionPage.ReadToEnd();
                    Console.WriteLine(fileAdditonPage);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();

            }




        }
    }
}
