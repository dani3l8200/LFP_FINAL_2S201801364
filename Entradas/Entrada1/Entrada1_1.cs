class MyProgram
{
    static void Main()
    {
        /*
        #################### Archivo de entrada #1 #################
        ## El objetivo de este archivo es evaluar el manejo   ######
        ## correcto de la tabla de simbolos.                  ######
        ## Los tipos aceptados son:                           ######
        ####### Int
        ####### Float
        ####### Char
        ####### String
        ####### Boolean
        */
        //Declaraciones basicas
        int x,y,z =520; // x=520 ,y=520 ,z = 520
        float x1,y1,z1 = 3.14; // x1 = 3.14, 3.14, 3.14
        bool x2,y2,z2 = true; // x2 = true, y2=true, z2= true
        char x3,y3,z3 = 'x'; // x3='x' , y3='x', z3='x'
        String x4,y4,z4 = "CadenaDefecto"; // x4="CadenaDefecto", y4="CadenaDefecto", z4="CadenaDefecto"
        Console.WriteLine(">>>>>>>>> Enteros <<<<<<<<<<<<<<<<");
        Console.WriteLine("x debe ser 520, segun la tabla de simbolos tiene ["+x+"]");
        Console.WriteLine("y debe ser 520, segun la tabla de simbolos tiene ["+y+"]");
        Console.WriteLine("z debe ser 520, segun la tabla de simbolos tiene ["+z+"]");
        Console.WriteLine(">>>>>>>>> Float  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X1 debe ser 3.14, segun la tabla de simbolos tiene ["+x1+"]");
        Console.WriteLine("y1 debe ser 3.14, segun la tabla de simbolos tiene ["+y1+"]");
        Console.WriteLine("z1 debe ser 3.14, segun la tabla de simbolos tiene ["+z1+"]");
        Console.WriteLine(">>>>>>>>> Bool  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X2 debe ser true, segun la tabla de simbolos tiene ["+x2+"]");
        Console.WriteLine("y2 debe ser true, segun la tabla de simbolos tiene ["+y2+"]");
        Console.WriteLine("z2 debe ser true, segun la tabla de simbolos tiene ["+z2+"]");
        Console.WriteLine(">>>>>>>>> Char  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X3 debe ser x, segun la tabla de simbolos tiene ["+x3+"]");
        Console.WriteLine("y3 debe ser x, segun la tabla de simbolos tiene ["+y3+"]");
        Console.WriteLine("z3 debe ser x, segun la tabla de simbolos tiene ["+z3+"]");
        Console.WriteLine(">>>>>>>>> String  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X4 debe ser CadenaDefecto, segun la tabla de simbolos tiene ["+x4+"]");
        Console.WriteLine("y4 debe ser CadenaDefecto, segun la tabla de simbolos tiene ["+y4+"]");
        Console.WriteLine("z4 debe ser CadenaDefecto, segun la tabla de simbolos tiene ["+z4+"]");
        Console.WriteLine("Si funciona todo, hasta el momento tengo 40 pts.");
        Console.WriteLine("    ");
        Console.WriteLine("    ");
        Console.WriteLine("    ");
        //Asignacion y expresiones aritmeticas...........
        x = 50*2+10/2; //105
        y = 3*3+5-2; //12
        z = (10*5)-(45/3)+5; //40
        Console.WriteLine(">>>>>>>>> Enteros <<<<<<<<<<<<<<<<");
        Console.WriteLine("x debe ser 105, segun la tabla de simbolos tiene ["+x+"]");
        Console.WriteLine("y debe ser 12, segun la tabla de simbolos tiene ["+y+"]");
        Console.WriteLine("z debe ser 40, segun la tabla de simbolos tiene ["+z+"]");
        x1 = 3.14*10.20+5.20/2.60; //34.028
        y1 = 7.36+(5.12/2.00)-(3.16*2.00); //3.6
        z1 = 5.5+(4.4-2.3)*0.5; //6.55
        Console.WriteLine(">>>>>>>>> Float <<<<<<<<<<<<<<<<");
        Console.WriteLine("X1 debe ser 34.028, segun la tabla de simbolos tiene ["+x1+"]");
        Console.WriteLine("y1 debe ser 3.6, segun la tabla de simbolos tiene ["+y1+"]");
        Console.WriteLine("z1 debe ser 6.55, segun la tabla de simbolos tiene ["+z1+"]");
        x2 = true;//true
        y2 = false;//false
        z2 = 5<=2;//false
        Console.WriteLine(">>>>>>>>> Bool  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X2 debe ser true, segun la tabla de simbolos tiene ["+x2+"]");
        Console.WriteLine("y2 debe ser false, segun la tabla de simbolos tiene ["+y2+"]");
        Console.WriteLine("z2 debe ser false, segun la tabla de simbolos tiene ["+z2+"]");
        x3 = 'a';
        y3 = 'b';
        z3 = 'c';
        Console.WriteLine(">>>>>>>>> Char  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X3 debe ser a, segun la tabla de simbolos tiene ["+x3+"]");
        Console.WriteLine("y3 debe ser b, segun la tabla de simbolos tiene ["+y3+"]");
        Console.WriteLine("z3 debe ser c, segun la tabla de simbolos tiene ["+z3+"]");
        x4 = "Cadena de prueba"+" 1";
        y4 = "Cadena de prueba"+" 2";
        z4 = "Cadena de prueba"+" 3";
        Console.WriteLine(">>>>>>>>> String  <<<<<<<<<<<<<<<<<");
        Console.WriteLine("X4 debe ser Cadena de prueba 1, segun la tabla de simbolos tiene ["+x4+"]");
        Console.WriteLine("y4 debe ser Cadena de prueba 2, segun la tabla de simbolos tiene ["+y4+"]");
        Console.WriteLine("z4 debe ser Cadena de prueba 3, segun la tabla de simbolos tiene ["+z4+"]");
        Console.WriteLine("Si funciona todo, hasta el momento tengo 70 pts.");
        Console.WriteLine("(x+50-10/2)*2= 190 R://"+(50+50-10/2)*2);
    }
}