using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaProjektZaliczenie
{
    class Presenting
    {
        public string error;

        public void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter("C:/Users/andyw/documents/visual studio 2015/Projects/AkademiaProjektZaliczenie/Wybrane.txt"))
            {
                try
                {
                    //foreach (string s uzupelniclistezopcjami )
                    //{
                    //    writer.WriteLine(s);
                    //}
                }
                catch
                {
                   error = "There is a problem with save results to file";
                }
            }
        }
    }
}
