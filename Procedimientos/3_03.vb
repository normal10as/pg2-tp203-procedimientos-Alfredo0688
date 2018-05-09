Module _3_03
    Sub main()

        Dim valorPotencial As Byte
        Console.Write("Ingresar un valor: ")
        valorPotencial = Console.ReadLine
        For n = 1 To 5

            Console.WriteLine("Potencia {0}: ", n & "º" & Potencia(n, valorPotencial))
            Console.ReadKey()

        Next

    End Sub

    Private Function Potencia(ByRef exponente As Byte, valor As Byte) As ULong

        Return valor ^ exponente

    End Function

End Module
