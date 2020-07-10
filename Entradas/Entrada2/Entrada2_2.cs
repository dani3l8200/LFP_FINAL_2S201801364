class MyProgram
{
    static void Main()
    {
        Console.WriteLine(">>>>>>>>>>>>>>>> SWITCH-CASE <<<<<<<<<<<<<<<<<<<<");
        //---------------- SWITCH - CASE ---------------------------------
        int iterador1 = 1;
        while(iterador1<10){
            int x =520/10+5; // x=57
            float x1 = 3.14*3; // x1 = 9.42
            bool x2 = 8<5; // x2 = false
            char x3 = 'b'; // x3='b'
            String x4 = "CadenaDefecto"; // x4="CadenaDefecto"
            switch(iterador1){
                case 1://Imprimir un int
                Console.WriteLine("Si funciona la concatenacion String-int [57] "+x);
                break;
                case 2://Imprimir un float
                Console.WriteLine("Si funciona la concatenacion String-float [9.42] "+x1);
                break;
                case 3://Imprimir un bool
                Console.WriteLine("Si funciona la concatenacion String-bool [false]"+x2);
                break;
                case 4://Imprimir un char
                Console.WriteLine("Si funciona la concatenacion String-char [b]"+x3);
                break;
                case 5://Imprimir un string
                Console.WriteLine("Si funciona la concatenacion String-strint [CadeaDefecto]"+x4);
                break;
                default:
                Console.WriteLine("No entre en ninguno de los casos "+iterador1);
                break;
            }
            iterador1 =  iterador1 + 1;
        }
    }
}
