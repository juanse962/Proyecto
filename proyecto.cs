/**
*  Juan Sebastian Gomez
*  Edwin Bedoya
*  Comparamos que la cadena de caracteres dada sea una secuencia de ADN de 3 caracteres
*  Nota: Se estara implementado un metodo para los caracteres respetidos
* https://github.com/juanse962/Proyecto
* https://es.wikipedia.org/wiki/Ley_de_Chargaff (Ley de Chargaf)
**/
using System;
      public class Proyecto

      {

            static void Main(string[] args)

            {
              int count1 = 0;
              int count2 = 0;
                  string cadena;
                  Console.WriteLine("Escribe la cadena");
                  cadena = Console.ReadLine();
                  cadena.ToUpper();
                   int longitud = cadena.Length;
                    if (longitud >= 3){
                    for(int i=0; i<=cadena.Length-1; i++){

                     if ((cadena[i] == 'T') ||(cadena[i] == 'C')){
                       count1 ++;
                     if ((cadena[i] == 'G') ||(cadena[i] == 'A')){
                       count2 ++;
                     }
                     }
                 }
                  }


                if (count2 != count1) {
                  Console.WriteLine("La cadena es correcta");
                }else {
                  Console.WriteLine("La cadena no es correcta");
                }
            }
          }
