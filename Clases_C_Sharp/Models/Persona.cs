using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_C_Sharp.Models
{

    public class Persona
    {
        /*Atajo: Para crear una propiedad de manera más rápida, se debe escribir "prop"+TAB
        Para crear getter y setter, al igual que en Java, el atajo es "propfull"+TAB.
        Con propfull, se crean atributos o variables con encapsulamiento inmediato.
        Ejemplo en SegundoNombre
        */

        public string PrimerNombre { get; set; }

        #region Atributo SegundoNombre creado con propfull
        private string segundoNombre;
        public string SegundoNombre
        {
            get { return segundoNombre.ToUpper(); }
            set { segundoNombre = value; }
        }
        #endregion
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public bool EsHombre { get; set; }
        public byte Edad { get; set; }
        private static int ContadorDeObjetos = 0;
        public int Id{ get; set; }

        #region Manejo de eventos en memoria
        #region Constructor
        public Persona()
            {
            //Al crear un objeto persona,la constante le asignara un valor ID:
            ContadorDeObjetos++;
            Id = ContadorDeObjetos;
            }
            #endregion

            #region Destructor
            ~Persona()
            {     
                Console.WriteLine($"Destruyendo objeto con ID: {this.Id}");
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            #endregion
        #endregion


        #region Manejo de funciones
        /// <summary>
        /// Creamos una función que nos retornará el sexo de manera más "bonita"
        /// </summary>
        /// <returns></returns>
        public string getSexo()
        {
            StringBuilder tipoSexo = new StringBuilder();
            if (this.EsHombre)
            {
                tipoSexo.Append("Masculino");
            }
            else
            {
                tipoSexo.Append("Femenino");
            }
            return tipoSexo.ToString();
        }
        #endregion


      


    }
}
