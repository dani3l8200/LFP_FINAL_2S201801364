class MyProgram
{
    static void Main()
    {
        /*
        #################### Archivo de entrada #2 #################
        ## El objetivo de este archivo es evaluar el manejo   ######
        ## correcto de ciclos.                  ######
        ## Los ciclos aceptados son:                           ######
        ####### While
        ####### For
        ####### Ademas se prueba si funciona el switch-case
        */
        Console.WriteLine(">>>>>>>>>>>>>>>> FOR <<<<<<<<<<<<<<<<<<<<");
        //---------------------- FOR -------------------------------
        
        String cadenaFor2 = "";
        int f;
        for(f=1;f<=7;f++)
        {
            cadenaFor2 =cadenaFor2 + "-"+ f ;
            if(f==7){
                cadenaFor2 = cadenaFor2+";";
            }
        }
        Console.WriteLine(cadenaFor2);
        Console.WriteLine(">>>>>>>>>>>>>>>> WHILE <<<<<<<<<<<<<<<<<<<<");
        //-------------------- WHILE --------------------------------
        int iterador = 0;
        while(iterador != (10*2)){
            Console.WriteLine("No soy 20, soy "+iterador);
            iterador = iterador + 1;
            if(iterador == (5*4)){
                Console.WriteLine("Soy 20, debo de detenerme");
            }
        }
    }
}