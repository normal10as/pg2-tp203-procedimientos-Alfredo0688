Module _3_09
    Private area As Single
    Sub main()

        Dim lado As Single
        Dim baseMenor As Single
        Dim baseMayor As Single
        Dim altura As Single

        Console.WriteLine("Resolver el area")

        lado = 1
        baseMenor = 10
        baseMayor = 20
        altura = 20

        Console.WriteLine("Area de un cuadrado: " & calcularArea(lado))
        Console.WriteLine("Area de un rectangulo: " & calcularArea(baseMayor, altura))
        Console.WriteLine("Area de un trapecio: " & calcularArea(baseMayor, baseMenor, altura))
        Console.ReadKey()
    End Sub

    Private Function calcularArea(lado As Single) As Single
        Return lado * lado
    End Function

    Private Function calcularArea(base As Single, altura As Single) As Single
        Return base * altura
    End Function

    Private Function calcularArea(basemenor As Single, basemayor As Single, altura As Single) As Single
        Return (basemayor + basemenor) / 2 * (altura)
    End Function

End Module
