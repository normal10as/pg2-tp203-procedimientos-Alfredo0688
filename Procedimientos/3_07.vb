Module _3_07

    Enum Operaciones As Byte
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()

        Console.WriteLine("Función sobrecargada")

        Console.WriteLine("Suma con dos parametros: " & Calcular(Operaciones.suma, 1, 8))

        Console.WriteLine("Resta con 3 parametros: " & Calcular(Operaciones.resta, 2, 10, 11))

        Console.WriteLine("Division con 4 parametros: " & Calcular(Operaciones.division, 8, 9, 7, 1))

        Console.WriteLine("Multiplicación con 4 parametros: " & Calcular(Operaciones.multiplicacion, 1, 5, 8, 9))

        Console.WriteLine("Predeterminada: " & Calcular(8, 987))

        Console.ReadKey()
    End Sub

    Private Function Calcular(operacion As Operaciones, valor1 As Short, valor2 As Short)
        If operacion.ToString = "suma" Then
            Return valor1 + valor2
        ElseIf operacion.ToString = "resta" Then
            Return valor1 - valor2
        ElseIf operacion.ToString = "multiplicacion" Then
            Return valor1 * valor2
        ElseIf operacion.ToString = "division" Then
            Return valor1 / valor2
        End If
    End Function

    Private Function calcular(operacion As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single)

        If operacion.ToString = "suma" Then
            Return valor1 + valor2 + valor3
        ElseIf operacion.ToString = "resta" Then
            Return valor1 - valor2 - valor3
        ElseIf operacion.ToString = "multiplicacion" Then
            Return valor1 * valor2 * valor3
        ElseIf operacion.ToString = "division" Then
            Return valor1 / valor2 / valor3
        End If

    End Function

    Private Function calcular(operacion As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single)
        If operacion.ToString = "suma" Then
            Return valor1 + valor2 + valor3 + valor4
        ElseIf operacion.ToString = "resta" Then
            Return valor1 - valor2 - valor3 - valor4
        ElseIf operacion.ToString = "multiplicacion" Then
            Return valor1 * valor2 * valor3 * valor4
        ElseIf operacion.ToString = "division" Then
            Return valor1 / valor2 / valor3 / valor4
        End If
    End Function

    Private Function calcular(valor1, valor2)
        Return valor1 + valor2
    End Function

End Module
