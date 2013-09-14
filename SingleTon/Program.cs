using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton s1 = Singleton.Instancia;
            System.Threading.Thread.Sleep(500);
            DateTime dateTime1 = DateTime.Now;
            Singleton s2 = Singleton.Instancia;
            if (s1 == s2)
            {
                Console.WriteLine("************************ El patrón Singleton **************************");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*    El patrón Singleton está diseñado para reducir la creación de    *");
                Console.WriteLine("*       instancias de un objeto de una clase a un único objeto.       *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*  Un uso práctico de este patrón podría ser para la clase núcleo de  *");
                Console.WriteLine("* un programa que establezca las conexiones con su base de datos y en *");
                Console.WriteLine("*   que nos interesaría tener solamente una instancia de la misma.    *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*               Tiempo de creación del primero objeto:                *");
                Console.WriteLine("*                           {0} milisegundos                          *", s1.CreatedTime.Millisecond);
                Console.WriteLine("*          Tiempo de llamada de creación del segundo objeto:          *");
                Console.WriteLine("*                           {0} milisegundos                          *", dateTime1.Millisecond.ToString());
                Console.WriteLine("*                Tiempo de creación del segundo objeto:               *");
                Console.WriteLine("*                           {0} milisegundos                          *", s2.CreatedTime.Millisecond.ToString());
                Console.WriteLine("***********************************************************************");
                Console.ReadKey();
            }
        }
    }
        

    public class Singleton
    {
        //Los ejemplos indican que hay que igualarla a null. ¿Es estrictamente necesario?
        private static Singleton _instancia;
        private static DateTime _createdTime;

        static Singleton()
        {
            //establecemos la fecha de creación del objeto de la clase Singleot
            _createdTime = DateTime.Now;
        }

        //Propiedad accesible para recuperar la instancia de la clase o crearla si no existe. 
        public static Singleton Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Singleton();

                return _instancia;
            }
        }

        //Propiedad para recuperar la fecha de creación de la primera instancia de la clase Singleton
        public DateTime CreatedTime
        {
            get
            {
                return _createdTime;
            }
        }
    }
}
