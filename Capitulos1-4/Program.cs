using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulos1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            int opc = 0;

            do
            {
                Console.Write("\n1) Ejercicio #1 Cap 1 \n2) Ejercicio #5 Cap 1 \n\n3) Ejercicio #1 Cap 2 \n4) Ejercicio #3 Cap 2 \n5) Ejercicio #4 Cap 2 \n6) Ejercicio #5 Cap 2 \n\n7) Ejercicio #1 Cap 3 \n8) Ejercicio #4 Cap 3 \n9) Ejercicio #5 Cap 3 \n\n10) Ejercicio #1 Cap 4 \n11) Ejercicio #2 Cap 4 \n12) Ejercicio #5 Cap 4 ");

                Console.Write("\n\nOpcion: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {

                    case 1://Ejercicio #1 Cap 1
                        Console.Write("Albert De Jesus Rosario Mendoza");
                        break;
                    case 2://Ejercicio #5 Cap 1
                        Console.WriteLine("Hey que tal, como esta eso");
                        Console.Write("Bien gracias a Dios");
                        break;
                    case 3://Ejercicio #1 Cap 2
                        CalcularPerimetro();
                        break;
                    case 4://Ejercicio #3 Cap 2
                        Radianes();
                        break;
                    case 5://Ejercicio #4 Cap 2
                        Fahrenheit();
                        break;
                    case 6://Ejercicio #5  Cap 2
                        ConversionDinero();
                        break;
                    case 7://Ejercicio #1 Cap 3
                        ParImpar();
                        break;
                    case 8://Ejercicio #4 Cap 3
                        DiaSemana();
                        break;
                    case 9://Ejercicio #5 Cap 3
                        PerimetroAreaPoligono();
                        break;
                    case 10://Ejercicio #1 Cap 4
                        Table();
                        break;
                    case 11://Ejercicio #2 Cap 4                        
                        Potencia();
                        break;
                    case 12://Ejercicio #5 Cap 4
                        Edad();
                        break;
                }
                Console.WriteLine();

            } while (opc != 0);

        }

        private static float Radianes()
        {
            int grados = 0;
            float res = 0.0f;
            Console.WriteLine(">>>>>>> Conversion a Radianes <<<<<<<");
            Console.Write("Digite Grados: ");
            grados = Convert.ToInt32(Console.ReadLine());

            res = Convert.ToSingle((grados * Math.PI) / 180);

            Console.WriteLine("{0} Grados = {1} Radian", grados, res);
            Console.WriteLine();
            return res;
        }

        private static float Fahrenheit()
        {
            int grados;
            float res = 0.0f;
            Console.WriteLine(">>>>>>> Conversion de °C a °F <<<<<<<");
            Console.Write("Ingrese Grados °C: ");
            grados = Convert.ToInt32(Console.ReadLine());

            res = Convert.ToSingle(((grados * 9) / 5) + 32);
            Console.WriteLine("{0} °C = {1} °F", grados, res);
            Console.WriteLine();
            return res;
        }

        private static void ConversionDinero()
        {
            int opc = 0, cantidad = 0;
            float dolar = 45.46f, euro = 56.0f, cambio = 0.0f;
            Console.WriteLine(">>>>>>> Conversion De Dolar y Euro <<<<<<<");
            Console.WriteLine("1) Dolar \n2)Euro");
            Console.Write("Opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Write("Digite Cantidad En Dolar: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    cambio = cantidad * dolar;

                    Console.WriteLine("Su Cambio Es: {0}", cambio);
                    break;
                case 2:
                    Console.Write("Digite Cantidad En Euro: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                    cambio = cantidad * euro;

                    Console.WriteLine("Su Cambio Es: {0}", cambio);
                    break;
                default:
                    Console.WriteLine("Cambio No Valido");
                    break;
            }
        }

        private static void ParImpar()
        {
            int num = 0;
            Console.WriteLine(">>>>>>> Verificar Si Un Numero Es Par o Impar <<<<<<<");
            Console.Write("Digite Un Numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El Numero Es Par");
            }
            else
            {
                Console.WriteLine("El Numero Es Impar");
            }
        }

        private static void DiaSemana()
        {
            int dia = 0;
            Console.WriteLine(">>>>>>> Muestra El Dia Correspondiente A Su Numero <<<<<<<");
            Console.Write("Digite Un Numero Entre 1-7 : ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {

                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia No Encontrado");
                    break;

            }
        }

        private static void PerimetroAreaPoligono()
        {
            int opc = 0;
            Console.WriteLine(">>>>>>> Calcular Perimetro y Area De Un Poligono Regular <<<<<<<");
            Console.Write("1) Perimetro \n2)Area");
            Console.Write("Opcion: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    CalcularPerimetro();
                    break;
                case 2:
                    CalcularArea();
                    break;
                default:
                    Console.WriteLine("Opcion No Valida");
                    break;
            }
        }

        private static double CalcularPerimetro()
        {
            double resultadoperimetro = 0;
            int cantidad = 0, lados = 0;

            Console.Write("Cantidad De Lados Del Poligono: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lados Del Poligono: ");
            lados = Convert.ToInt32(Console.ReadLine());

            resultadoperimetro = cantidad * lados;

            Console.WriteLine("El Perimetro Es: {0}", resultadoperimetro);

            return resultadoperimetro;

        }

        private static double CalcularArea()
        {
            double resultadoArea = 0, perimetro = 0, apotema = 0, area = 0;

            Console.Write("Digite Perimetro: ");
            perimetro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite Apotema: ");
            apotema = Convert.ToInt32(Console.ReadLine());

            area = perimetro * apotema;

            resultadoArea = area / 2;

            Console.WriteLine("El Area es: {0}", resultadoArea);
            return resultadoArea;
        }

        private static void Table()
        {
            int num = 0;
            Console.WriteLine(">>>>>>> Tabla De Multiplicacion 1-10 <<<<<<<");
            for (int i = 1; i <= 10; ++i)
            {
                for (int j = 1; j <= 10; ++j)
                {
                    num = i * j;
                    Console.WriteLine(i + " x " + j + " = " + num);
                }
                Console.WriteLine();

            }
        }

        private static void Potencia()
        {
            double num = 0;
            double exp = 1;
            Console.WriteLine(">>>>>>> Elevar Un Numero A Cualquier Exponente <<<<<<<");

            Console.Write("Digite Base: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite Exponente: ");
            exp = Convert.ToInt32(Console.ReadLine());

            object res = Math.Pow(num, exp);

            Console.WriteLine(num + " ^ " + exp + " = " + res);
            Console.WriteLine();
        }

        private static void Edad()
        {
            int mayor = -100, menor = 100;
            int edad, cant;
            Console.WriteLine(">>>>>>> Promedio De Edades De Un Grupo De Personas <<<<<<<");
            Console.Write("Ingrese Cantidad Edades: ");
            cant = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cant; ++i)
            {
                Console.Write("Digite Edad " + i + ": ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad > mayor)
                    mayor = edad;

                if (edad < menor)
                    menor = edad;
            }

            Console.WriteLine(">> Edad Mayor {0} << >> Edad Menor {1} << ", mayor, menor);
            Console.WriteLine();

        }
    }
}
