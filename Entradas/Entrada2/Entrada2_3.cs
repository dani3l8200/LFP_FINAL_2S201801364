class MyProgram
{
    static void Main()
    {
        for(int i=0;i<=5;i++){
            Console.WriteLine("Estoy en la iteracion i="+i);
            Console.WriteLine("se debe de imprimir j desde 5 hasta ["+i+"]");
            int j=0;
            for(j=5;j>=i;j--){
                Console.WriteLine("          Estoy en la iteracion j="+j);
                if(j==i){
                    Console.WriteLine("J ya termino, debo de detenerme");
                }
            }
            if(i==5){
                Console.WriteLine("Ya termine todo, si funciona los for anidados");
            }
        }
    }
}