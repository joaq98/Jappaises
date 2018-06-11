using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Ingrese nombre de Paises deseados - Para terminar ingrese Esc");
            List<string> comandos = new List<string>();
            string comando = Console.ReadLine();

            while (comando != "Esc" && 15 != comandos.Count)
            {
                comandos.Add(comando);
                comando = Console.ReadLine();
                if (comandos.Count == 15) Console.Out.WriteLine("Maximo numero de paises ingresados");
            }

            Console.Out.WriteLine("Sus Paises ingresados fueron : \n");
            for (int i = 0; i < comandos.Count; i++)
            {
                Console.Out.WriteLine(comandos[i])
            }

            Console.Out.WriteLine("Fin del programa - Apriete una tecla para salir");
            Console.ReadLine();



        }
    }
}
