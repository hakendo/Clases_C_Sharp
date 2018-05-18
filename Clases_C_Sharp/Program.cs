using Clases_C_Sharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Para iniciar el manejo de clases(Objetos), primero crearemos una carpeta llamada "Models",
             * donde almacenaremos nuestros modelos de clases.
             */

            /*
             * 1.- A través de una clase, creamos un objeto:
             * Incluímos la libreria: using Clases_C_Sharp.Models;
             */
            Persona personaEjemplo = new Persona() {
                Edad = 24,
                EsHombre = true,
                PrimerNombre = "Moisés",
                SegundoNombre = "Alexis",
                PrimerApellido = "Cadima",
                SegundoApellido = "Figueroa"
            };

            /*
             * Hemos creado una persona con el nombre de personaEjemplo, esta persona tiene valores iniciales indicados anteriormente.
             * Mostraremos informacion a través de la consola:
            */
            //Creamos un string a través de StringBuilder, para hacer buen uso de la memoria:
            StringBuilder MensajeSalida = new StringBuilder();
            MensajeSalida.AppendLine($"El Id de la persona es: {personaEjemplo.Id}");
            MensajeSalida.AppendLine($"Primer nombre: {personaEjemplo.PrimerNombre}");
            MensajeSalida.AppendLine($"Segundo nombre: {personaEjemplo.SegundoNombre}");
            MensajeSalida.AppendLine($"Primer apellido: {personaEjemplo.PrimerApellido}");
            MensajeSalida.AppendLine($"Segundo apellido: {personaEjemplo.SegundoApellido}");
            MensajeSalida.AppendLine($"La persona es de sexo: {personaEjemplo.getSexo()}");

            Console.WriteLine($"{MensajeSalida.ToString()}");
            Console.WriteLine("Presione cualquier tecla para continuar*****");
            Console.ReadLine();


            Persona personaEjemplo2 = new Persona()
            {
                Edad = 32,
                EsHombre = true,
                PrimerNombre = "Fabian",
                SegundoNombre = "Alfonso",
                PrimerApellido = "Norambuena",
                SegundoApellido = "Perez"
            };

            MensajeSalida.Clear();
            MensajeSalida.AppendLine($"El Id de la persona es: {personaEjemplo2.Id}");
            MensajeSalida.AppendLine($"Primer nombre: {personaEjemplo2.PrimerNombre}");
            MensajeSalida.AppendLine($"Segundo nombre: {personaEjemplo2.SegundoNombre}");
            MensajeSalida.AppendLine($"Primer apellido: {personaEjemplo2.PrimerApellido}");
            MensajeSalida.AppendLine($"Segundo apellido: {personaEjemplo2.SegundoApellido}");
            MensajeSalida.AppendLine($"La persona es de sexo: {personaEjemplo2.getSexo()}");
            Console.WriteLine($"{MensajeSalida.ToString()}");
            Console.WriteLine("Presione cualquier tecla para continuar*****");
            Console.ReadLine();
        }
    }
}
