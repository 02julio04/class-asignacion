using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturarDatos
{
    internal class Program
    {

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("MVP: ");
            Console.WriteLine("1-Agregar");
            Console.WriteLine("2-Ver informacion");
            Console.WriteLine("3-Salir");

            Console.WriteLine("Digite su opcion");
            string opc = Console.ReadLine();

            if (opc == "1")
            {
                agregarInfo();
            }
            else if (opc == "2")
            {
                verInformacion();
            }
            else if (opc == "3")
            {
                Console.WriteLine("Adiosss");
            }
            else
            {
                Console.WriteLine("Debe elegir una opcion valida, presiona enter para continuar ");
                Console.ReadKey();
                Program.menu();
            }

        }
        class informacion
        { 
            public string name { get; set; }
            public string lastname { get; set; }
            public int edad { get; set; }
        }

        static void agregarInfo()
        {
            Console.Clear();
            Console.WriteLine("");
            informacion infor = new informacion();

            Console.WriteLine("Digite su nombre: ");
            infor.name = Console.ReadLine();

            Console.WriteLine("Digite su apellido: ");
            infor.lastname = Console.ReadLine();

            Console.WriteLine("Digite su edad: ");
            infor.edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Informacion guardada, presiona enter para continuar");
            Console.ReadKey();
            Program.menu();
        }
        static void verInformacion()
        {
            Console.Clear();
            Console.WriteLine("Aqui estan todas las personas agregadas");
            Console.WriteLine("name \t lastname \t edad");

            Console.WriteLine(" presiona enter para continuar");
            Console.ReadKey();
            Program.menu();
        }
        static void Main(string[] args)
        {
            Program.menu();
            var json = "{\name}";
            Console.ReadKey();
        }
    }
}
