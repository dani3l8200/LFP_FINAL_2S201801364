class MyProgram
{
    static void Main()
    {
        /*
        #################### Archivo de entrada #4 #################
        ## El objetivo de este archivo es evaluar el manejo   ######
        ## correcto de arreglos.                  ######
        */
        Console.WriteLine(">>>>>>>>>>>>>>> CASO #1 <<<<<<<<<<<<<<<<<<<<<<<<<<");
        int[] NotasEstudiantes = {8,4,6,9,10,3,5};
        int aprobados, reprobados,f;
        for(f=0;f<7;f++){
            if(NotasEstudiantes[f]>=7){
                aprobados = aprobados + 1;
            }else{
                reprobados = reprobados + 1;
            }
        }
        Console.WriteLine("Deben de haber 3 aprobados, se sumaron "+aprobados);
        Console.WriteLine("Deben de haber 4 reprobados, se sumaron "+reprobados);

        Console.WriteLine(">>>>>>>>>>>>>>> CASO #2 <<<<<<<<<<<<<<<<<<<<<<<<<<");
        int[] ladoA = {3,4,6,7,1,1};
        int[] ladoB = {3,4,3,7,2,9};
        int[] ladoC = {3,5,6,7,3,9};
        int cantidadEquilatero, cantidadIsoceles, cantidadEscaleno;
        for(int f1 = 0;f1<6;f1++){
            int lado1 = ladoA[f1];
            int lado2 = ladoB[f1];
            int lado3 = ladoC[f1];
            int bandera = 0;
            if(lado1 == lado2){
                if(lado1 == lado3){
                      cantidadEquilatero = cantidadEquilatero+1;
                      bandera = 1;
                }
            }
            if(bandera == 0){
                if(lado1 == lado2){
                        cantidadIsoceles = cantidadIsoceles + 1;
                }else{
                    if(lado1 == lado3){
                        cantidadIsoceles = cantidadIsoceles + 1;
                    }else{
                        if(lado2 == lado3){
                            cantidadIsoceles = cantidadIsoceles + 1;
                        }else{
                            cantidadEscaleno = cantidadEscaleno + 1;
                        }   
                    }
                }
            }
        }
        Console.WriteLine("Debe de haber solo un escaleno, hay "+cantidadEscaleno);
        Console.WriteLine("Debe de haber tres iscoleses, hay "+cantidadIsoceles);
        Console.WriteLine("Debe de haber dos equilateros, hay "+cantidadEquilatero);
        Console.WriteLine(">>>>>>>>>>>>>>> CASO #3 <<<<<<<<<<<<<<<<<<<<<<<<<<");
        int[] arr = {10, 80, 30, 90, 40, 50, 70};
        graficarVector(arr,"AntesBubleSort");
        int n = 7;  
        int temp = 0;  
         for(int i=0; i < n; i++){  
                 for(int j=1; j < (n-i); j++){  
                          if(arr[j-1] > arr[j]){  
                                 //swap elements  
                                 temp = arr[j-1];  
                                 arr[j-1] = arr[j];  
                                 arr[j] = temp;  
                         }  
                 }  
         }
        graficarVector(arr,"DespuesBubbleSort");
 

    }
}