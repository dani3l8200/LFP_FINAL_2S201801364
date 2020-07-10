class MyProgram
{
    static void Main()
    {
         String whileAnidado = "";
        int i1 = 1;
        while (i1 <= 6) {
            whileAnidado = whileAnidado + "Ficha: ";
            int j1 = 1;
            while (j1 <= i1) {
                whileAnidado = whileAnidado + "|" + i1 + ":" + j1 + "| ";
                j1 = j1 + 1;
            }
            Console.WriteLine(whileAnidado);
            i1 = i1 + 1;
        }
    }
}