Module _3_04
    Sub main()

        Dim ladoa As Short
        Dim ladob As Short
        Console.WriteLine("Ingrese los dos lados de un triangulo rectangulo ")
        Do
            Console.Write("Lado A: ")
            ladoa = Console.ReadLine
        Loop Until validarDato(ladoa) = True
        Do
            Console.Write("Lado B: ")
            ladob = Console.ReadLine
        Loop Until validarDato(ladob) = True

        Console.WriteLine("Hipotenusa: " & calcularHipotenusa(ladoa, ladob))
        Console.ReadKey()



    End Sub

    Private Function calcularHipotenusa(lado_a As Byte, lado_b As Byte) As Single
        Dim hipotenusa As Single = Math.Pow(lado_a, 2) + Math.Pow(lado_b, 2)
        Return Math.Pow(hipotenusa, 2)
    End Function

    Private Function validarDato(lado) As Boolean

        If lado > 0 Then
            Return True
        End If
        Return False
    End Function

End Module
