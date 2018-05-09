Module _3_01

    Sub Main()

        fechaActual()
        Console.WriteLine(horaActual())
        Console.ReadKey()
    End Sub

    Private Sub fechaActual()
        Dim fecha As New DateTime(Year(Now), Month(Now), Day(Now))

        Console.WriteLine("Fecha actual: Año:{0} Mes:{1} Dia:{2} ", fecha.Year, fecha.Month, fecha.Day)

    End Sub

    Private Function horaActual() As String
        'Return "Hora: {0} Minuto: {1} Segundo: {2}" & Date.Now.Hour & Date.Now.Minute & Date.Now.Second
        Return "Hora: " & Date.Now.Hour & " Minuto: " & Date.Now.Minute & " Segundo: " & Date.Now.Second
    End Function

End Module
