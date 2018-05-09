Module _3_06



    Sub main()

        Dim numero As Byte
        Dim Sumatoria As UShort

        Console.Write("Ingresar número: ")
        numero = Console.ReadLine

        For n = 1 To numero

            calcularSumatoria(Sumatoria, n)

        Next

        Console.WriteLine("Sumatoria: " & Sumatoria)
        Console.ReadLine()

    End Sub

    Private Sub calcularSumatoria(ByRef sumatoria As UShort, valor As UShort)
        sumatoria = sumatoria + Math.Pow(valor, 2)
    End Sub

End Module
