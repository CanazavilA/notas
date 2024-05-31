using System;
using System.Numerics;
namespace miLibreria{
    
  class miClase{

    static void Main(){

        int contador = 1;

        int[,] matriz = new int [3,4];
            for(int j=0; j< 3; j++){
            for(int i=0; i<4; i++) {
              
                matriz[j,i]= contador;

                contador++; 

                 }
               
            }
                for(int j=0; j<3; j++){
                    for (int i=0; i<4; i++){
                        Console.WriteLine("Matriz({0},{1}): {2}",j,i,matriz[j,i]);
                    }
                }
   
    }

  }
}