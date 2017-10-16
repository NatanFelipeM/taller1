Option Strict On
Module Module1

    Sub Main()
        Dim numx, numy As Double
        Dim suma As Double
        Dim resta As Double
        Dim multiplicacion As Double

        Console.WriteLine("Coloque los números que quiere calcular:")

        numx = Convert.ToDouble(Console.ReadLine())
        numy = Convert.ToDouble(Console.ReadLine())
        suma = numx + numy
        resta = numx - numy
        multiplicacion = numx * numy


        Console.WriteLine("Los resultados son: ")
        Console.WriteLine("suma." & suma & " resta." & resta & " multiplicación." & multiplicacion)

        Console.ReadLine()










    End Sub

End Module
