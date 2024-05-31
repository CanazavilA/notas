using System;
using System.Numerics;
class miClase {

    /*Hacer un programa que permita cargar por programa 6 notas de un alumno en un vector
      luego de cargar todas las notas. debera recorrer el vector de dichas notas
      para mostrar la nota mas alta, la nota mas baja y el promedio general.
    */
    static void Main (){

        //declaracion del vector
            int[] vector = new int[6];

            int mayor = 0;
            int menor = 0;
            int acumulador = 0;

        //llenado del vector
            for (int i=0 ; i<=5 ; i++){
                
                Console.Write("Ingrese la nota ({0}):", i+1);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

        menor = vector[0];

        foreach (var elemento in vector) {

                if (elemento > mayor){
                    mayor=elemento;
                }

                if (elemento < menor){
                    menor=elemento;
                }

                acumulador = acumulador + elemento;
            

            }   
                Console.WriteLine("mayor: {0}",mayor);
                Console.WriteLine("menor: {0}",menor);
                Console.WriteLine("suma: {0}",acumulador);
                Console.WriteLine("promedio: {0}",acumulador/6);
        }
    }