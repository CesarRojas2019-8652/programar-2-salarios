using System;

namespace programa_2_salarios
{
    class Psalarios
    {
        private string[] empleados;
        private int[] salario;
        private int[] salariotot;

        public void Cargar() 
        {
            empleados=new String[5];
            salario=new int[5,2];
            for(int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese nombre del empleado:");
                empleados[f]=Console.ReadLine();
                for(int c = 0; c < salario.GetLength(1); c++) 
                {
                    Console.Write("Ingrese el sueldo de la persona:");
                    string linea;
                    linea = Console.ReadLine();
                    salario[f,c]=int.Parse(linea);
                }
            }
        }

        public void CalculoSumaSalarios()
        {
            salariotot = new int[10];
            for (int f = 0; f < salario.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < salario.GetLength(1); c++)
                {
                    suma = suma + salario[f,c];
                }
                salariotot[f] = suma;
            }
        }

        public void dinerototal() 
        {
    	    Console.WriteLine("Total de sueldos pagados por empleado.");
            for(int f = 0; f < salariotot.Length; f++) 
            {
                //Console.WriteLine(empleados[f]+" - "+salariotot[f]);
            }
        }

        public void salariomayor() 
        {
            int smayor=salariotot[0];
            string nomemp=empleados[0];
            for(int f = 0; f < salariotot.Length; f++) 
            {
                if (salariotot[f] > smayor) 
                {
                    smayor=salariotot[f];
                    nomemp=empleados[f];
                }
            }
            Console.Clear();
            Console.WriteLine("El empleado con el salario mayor es " + nomemp);
            Console.WriteLine("que tiene un sueldo de "+ smayor +" mayor");
            
        }

        static void Main(string[] args)
        {
            Psalarios ma = new Psalarios();
            ma.Cargar();
            ma.CalculoSumaSalarios();
            ma.dinerototal();
            ma.salariomayor();
            Console.ReadKey();
        }
    }
}
