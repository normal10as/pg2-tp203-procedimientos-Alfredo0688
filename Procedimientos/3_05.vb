Module _3_05
    Private Const pi As Single = 3.1415926500000002
    Sub main()
        Dim radio As Short
        Dim altura As Short
        Console.WriteLine("Calcular el volumen de un cilindro")
        Do
            Console.Write("Ingrese el radio de la base: ")
            radio = Console.ReadLine
        Loop Until validarDato(radio)
        Do
            Console.Write("Ingrese la altura: ")
            altura = Console.ReadLine
        Loop Until validarDato(altura)
        Console.WriteLine("Volumen del cilindro: " & calcularVolumen(radio, altura))
        Console.ReadKey()


    End Sub

    Private Function calcularVolumen(radio As Short, altura As Short)

        Dim volumen As Single = pi * Math.Pow(radio, 2) * altura

        Return volumen

    End Function

    Private Function validarDato(valor As Short) As Boolean
        If valor > 0 Then
            Return True
        End If
        Return False
    End Function

End Module
