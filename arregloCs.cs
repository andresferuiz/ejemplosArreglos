using System;
namespace arregloCs
{

class arregloCs
{
       

        static void Main(string[] args) {
    

    
    double [,,] nota = new double[2,2,2];
double suma1=0, suma2=0, Promedio1=0, Promedio2=0;
    
   
  for(int k=0; k< 2; k++){  
    for(int i=0; i< 2; i++){

        for(int j=0; j< 2; j++){

            int contMes = 1;
            contMes = contMes + k ;
            
            int contEst = 1;
            contEst = contEst + i ;
            
            int contMat = 1;
            contMat = contMat + j ;

            Console.WriteLine(" Mes "+ contMes +" Estudiante "+ contEst +" Escriba la nota de la materia " + contMat);

            nota[i,j,k] = Convert.ToDouble(Console.ReadLine());
            
            
            
        }
        }
        }
        suma1 = suma1 + nota[0,0,0]+nota[0,1,0]+nota[0,0,1]+nota[0,1,1]; 
        Promedio1 = suma1 / 4;
  
        suma2 = suma2 + nota[1,0,0]+nota[1,1,0]+nota[1,0,1]+nota[1,1,1]; 
        Promedio2= suma2 / 4;
  
  
   
     
    Console.WriteLine("El Promedio del estudiante 1 es: " + Promedio1);
    
    
   
    Console.WriteLine("El Promedio del estudiante 2 es: " + Promedio2);
    
    
    

    }

}
}