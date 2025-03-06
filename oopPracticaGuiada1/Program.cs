using System;
using System.Runtime.InteropServices;

namespace oopPracticaGuiada {
    public class Program {

        public const int EXIT = 4;

        public static string DecimalToBinary(int input) {
            return Convert.ToString(input, 2);
        }

        // FUNCIONES SOLICITADAS


        public static void PrintConversion(int conversion, int input, string output) {
            string name = "";
            if (conversion == 1) {
                name = "binaria";
            } 
            else if (conversion == 2) {
                name = "octal";
            } 
            else if (conversion == 3) {
                name = "hexadecimal";
            }

            Console.WriteLine($"El número {input} en representación {name} es {output}");
            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public static void Main() {
            int opcion = 1;

            while(opcion >= 1 && opcion < EXIT) {
                Console.clear();

                Console.WriteLine("1. Decimal a binario");
                Console.WriteLine("2. Decimal a octal");
                Console.WriteLine("3. Decimal a hexadecimal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Introduzca una opción: ");
                string? tmp = Console.ReadLine();

                if (tmp == null || tmp == "") {
                    opcion = EXIT;
                } 
                else {
                    opcion = int.Parse(tmp);
                }

                Console.Write("Introduzca un número: ");

                int input = int.Parse(Console.ReadLine());
                string output = "";

                if (opcion == 1) {
                    output = DecimalToBinary(input);
                }

                //RESTO DE OPCIONES

                PrintConversion(opcion, input, output);
            }
        }
    }
}
