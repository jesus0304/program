using System;

namespace Contacts
{
    class Program
    {
        static void Main( cadena [] args)
        {

            cadena cadena = "" ;
            int edad = 0 ;
            doble altura = 0 . 0 ;


            Console.WriteLine("Hola, por favor ingresa tu edad");
            cadena = consola . Readline ();
            edad = Convertir . Toint32 (cadena);


            si (edad >= 18 )

            Consola . WriteLine ( " Disculpe ha superado el límite de edad para el parque. " );
        } }
            demás
            {
                
                
                Consola . WriteLine ( " Bienvenido " );
                
                Consola . WriteLine ( " ¿cual es tu altura? En metros " );
                cadena  =  Consola . ReadLine ();
                altura  =  Convertir . ToDouble ( cadena );
                
                si ( altura  <  1 . 6 )
                {
                Consola . WriteLine ( " Puedes ir a la casa encantada, el gusanito y el carrusel " );    
                }
                demás
                {
                    Consola . WriteLine ( " Puedes ir a la casa encantada, el gusanito, el carrusel y la montaña rusa " );
                
                }
                //
            }
            
            
            
            
            Consola . ReadKey ();
        
    }
}
