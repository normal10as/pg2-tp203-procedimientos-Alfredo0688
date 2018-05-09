Module _3_08

    Enum Operaciones As Byte
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()
        Console.WriteLine("Subrutina sobrecargada")

        resultado(Operaciones.suma, 1, 8)

        resultado(Operaciones.resta, 8, 9, 55)

        resultado(Operaciones.multiplicacion, 8, 9, 1, 2)

        resultado(8, 6)
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

    Private Sub resultado(operacion As Operaciones, valor1 As Single, valor2 As Single)
        Console.WriteLine(Calcular(operacion, valor1, valor2))

    End Sub

    Private Sub resultado(operacion As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single)

        Console.WriteLine(Calcular(operacion, valor1, valor2, valor3))

    End Sub

    Private Sub resultado(operacion As Operaciones, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single)

        Console.WriteLine(Calcular(operacion, valor1, valor2, valor3, valor4))

    End Sub

    Private Sub resultado(valor1 As Single, valor2 As Single)
        Console.WriteLine(Calcular(valor1, valor2))
    End Sub

End Module
