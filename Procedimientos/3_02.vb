Module _3_02
    Sub main()

        Dim fecha As Date
        Dim dias As UShort

        Console.Write("Ingresar una fecha cualquiera en el formato DD/MM/AA: ")
        fecha = Console.ReadLine
        Console.Write("Ingresar cantidad de dias a agregar a la fecha anterior: ")
        dias = Console.ReadLine

        Console.WriteLine(sumarDias(fecha, dias))
        Console.ReadKey()

    End Sub

    Private Function sumarDias(fecha As Date, dias As UShort)

        Dim nuevafecha As String = fecha.AddDays(dias)
        Return nuevafecha

    End Function
End Module
