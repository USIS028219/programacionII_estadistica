using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionII_estadistica
{
    class ConversionesParcial
    {

        public string[][] Conversor = {
            new string[] {"Dolares", "Colones(SV)","Yenes","Rupias","Peso(Chileno)","Peso(Mexicano)","Peso(Argentino)","Bitcoin"},
            new string[] {"Megabyte","Bit","Byte","Kilobyte","Gigabyte","Terabyte" }
        };

        double[][] valores ={
            new double[] {1,8.75,111.27,69.75,667.08,19.36,39.69,0.00026},
            new double[] {1,8368608,1048576,1024,0.0009765625, 0.00000095367431660625}
        };

        public double conversiones(int opcion, int De, int A, double cantidad)
        {
            return valores [opcion][A] / valores[opcion][De] * cantidad;
        }
         
           
     }
        

 }



   