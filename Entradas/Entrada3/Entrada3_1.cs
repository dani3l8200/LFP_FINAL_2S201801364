class MyProgram
{
    static void Main()
    {
        /*
        #################### Archivo de entrada #3 #################
        ## El objetivo de este archivo es evaluar el manejo   ######
        ## correcto de arreglos.                  ######
        */
        Console.WriteLine("Vector 1 ........................");
        int[] vector = {1,2,3,4,5};
        graficarVector(vector, "Vector1");
        
        Console.WriteLine("Vector 2 ....................");
        int factor = 10;
        //El vector es {10,20,30,40,50}
        int[] vector1 = {factor*1,factor*2,factor*3,factor*4,factor*5};
        graficarVector(vector1,"Vector2");

        Console.WriteLine("Vector 3.......................");
        int tamanioArreglo = 5;
        //El arreglo es {6,7,8,9,10}
        int[] arreglo = { tamanioArreglo+1, tamanioArreglo+2, tamanioArreglo+3,tamanioArreglo+4,tamanioArreglo+5 };
        int[] arreglo1 = new int[tamanioArreglo];
        Console.WriteLine(">>>>>>> Arreglo <<<<<<<<<<");
        for(int i=0;i<tamanioArreglo;i++){
            Console.WriteLine(arreglo[i]);
            arreglo1[i] = i;
        }
        //Arreglo1 de 5 posiciones {0,1,2,3,4}.
        Console.WriteLine(">>>>>>> Arreglo1 <<<<<<<<<<");
        int j = 0;
        while(j<tamanioArreglo){
            Console.WriteLine(arreglo1[j]);
            j = j +1;
        }
        graficarVector(arreglo, "arreglo");
        graficarVector(arreglo1, "arreglo1");

        Console.WriteLine("Vector 4.......................");
        String[] vectorStrings = new String[tamanioArreglo];
        int iterador = 0;
        while(iterador<tamanioArreglo){
            vectorStrings[iterador]= "Posicion "+iterador;
            iterador = iterador + 1;
        }

        for(int i1=tamanioArreglo;i1>0;i1--){
            Console.WriteLine(vectorStrings[i1-1]);
        }
        graficarVector(vectorStrings, "Vector String");

        Console.WriteLine("Vector 5........................");
        char[] vectorChar = {'a','b','c','d','e','f','g','h'};
        for(int i2=0;i2<8;i2++){
            Console.WriteLine(vectorChar[i2]);
        }
        graficarVector(vectorChar, "Vector char");

        String[] nombres = {"Juan","Pedro","Mario","Gabriela"};
        float[] sueldos = {5000.75, 2360.50, 8000.23, 4300.12} ; 

        float mayor = sueldos[0];
        int pos;
        for (int f = 1; f < 4; f++){
            if (sueldos[f] > mayor){
                mayor = sueldos[f];
                pos = f;
            }
        }
        Console.WriteLine("El empleado con sueldo mayor es :" + nombres[pos]);
        Console.WriteLine("Tiene un sueldo de: " + mayor);
        Console.WriteLine("Vector 6........................");
        int[] vectorA = {10,20,30,40,50};
        int[] vectorB = {1,2,3,4,5};
        int[] vectorC = new int[5];
        int[] vectorD = new int[5];
        for(int f1=0;f1<5;f1++){
            vectorC[f1] = vectorA[f1]+vectorB[f1];
            vectorD[f1] = vectorB[f1]-vectorA[f1];
        }
        graficarVector(vectorA,"VectorA");
        graficarVector(vectorB,"VectorB");
        graficarVector(vectorC,"VectorC");
        graficarVector(vectorD,"VectorD");
    }
}