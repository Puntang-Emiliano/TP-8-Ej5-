/*En base al ejercicio anterior, se debe solicitar al usuario que ingrese un día y mes del año,
 para luego calcular y mostrar por pantalla la cantidad de días que quedan hasta el fin de año.*/


using System;

namespace Ej5_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dia, mes, contador=0;
            string[] mesees={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Dicienmbre"};
            int[] dias={31,28,31,30,31,30,31,31,30,31,30,31};

            Console.Clear();
            System.Console.WriteLine( "--------BIENVENIDO AL SISTEMA--------");
            System.Console.WriteLine("Por favor ingrese UN MES del 1 al 12");
            mes=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Por favor ingrese el DIA del mes seleccionado, para saber cuanto falta para terminar el Año");
            dia=Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = mes-1; i<12; i++)
            {
                contador= contador+ dias[i];
            }
            Console.Clear();
            Console.WriteLine("ELIGIO EL DIA : " + dia);
            Console.WriteLine("ELIGIO EL MES : " + mesees[mes-1]);
            Console.WriteLine("FALTA PARA TERMINAR EL AÑO {0} DIAS " , contador-dia);

            Console.ReadKey();
        }
    }
}
