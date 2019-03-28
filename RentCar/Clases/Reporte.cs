using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RentCar.Clases
{
    class Reporte
    {
        public static void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText("D:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        public static void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText("D:\\prueba.csv"))
            {
                w.WriteLine(pLine);
            }
        }
    }
}
