/**
*  Juan Sebastian Gomez
*  Edwin Bedoya
*  Comparamos que la cadena de caracteres dada sea una secuencia de ADN de 3 caracteres
*  Nota: Se estara implementado un metodo para los caracteres respetidos
**/
using System;
      public class Proyecto

      {

            static void Main(string[] args)

            {
                  string cadena;
                  Console.WriteLine("Escribe la cadena");
                  cadena = Console.ReadLine();
                  cadena.ToUpper();
                   int longitud = cadena.Length;
                    if (longitud >= 3){
                    for(int i=0; i<cadena.Length-1; i++){
                    //  Console.WriteLine("I {0}",i);
                        switch(cadena[i]) {
                              case 'T':
                                    if  (cadena[i+1]== 'G' || cadena[i+1]== 'C' || cadena[i+1]== 'A') {
                                  }
                                  else {
                                    Console.WriteLine("La cadena no es correcta");
                                      break;
                                  }
                                    break;
                              case 'A':
                              if  (cadena[i+1]== 'G' || cadena[i+1]== 'C' || cadena[i+1]== 'T') {

                               }
                               else {
                                 Console.WriteLine("La cadena no es correcta");
                                   break;
                               }
                              break;
                        }
                    }

                  }
                  else {
                    Console.WriteLine("La cadena no es correcta");
                  }
                }
            }
