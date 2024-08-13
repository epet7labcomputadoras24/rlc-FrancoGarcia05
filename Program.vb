Imports System

Module Program
    Sub Main(args As String())
        Dim f As Single
        Dim L As Single
        Dim C As Single
        Dim R As Single
        Dim XL As Single
        Dim XC As Single
        Dim X As Single
        Dim Zt As Single
        Dim fr As Single
        Dim T As Single
        Console.WriteLine("Ingrese el valor de la frecuencia")
        f = Console.ReadLine()
        Do Until f >= 0
            Console.WriteLine("Intentelo de nuevo, la frecuencia no puede ser negativa")
            f = 0
            f = Console.ReadLine()
            Continue Do
            Exit Do
        Loop
        Console.WriteLine("Ingresse el valor de la inductancia")
        L = Console.ReadLine()
        Do Until L >= 0
            Console.WriteLine("Intentelo de nuevo, la inductancia no puede ser negativa")
            L = 0
            L = Console.ReadLine()
            Continue Do
            Exit Do
        Loop
        Console.WriteLine("Ingrese el valor de la capacitancia")
        C = Console.ReadLine()
        Do Until C >= 0
            Console.WriteLine("Intentelo de nuevo, la capacitancia no puede ser negativa")
            C = 0
            C = Console.ReadLine()
            Continue Do
            Exit Do
        Loop
        Console.WriteLine("Ingresse el valor de la resistencia")
        R = Console.ReadLine()
        Do Until R >= 0
            Console.WriteLine("Intentelo de nuevo, la resistencia no puede ser negativa")
            R = 0
            R = Console.ReadLine()
            Continue Do
            Exit Do
        Loop
        XL = 2 * 3.14 * f * L
        XC = 1 / (2 * 3.14 * f * C)
        X = XL - XC
        Zt = Math.Sqrt((X) ^ (2) + (R) ^ (2))
        T = Math.Atan(X / R) * 180 / 3.14
        fr = 1 / (2 * 3.14 * (Math.Sqrt(L * C)))
        Console.WriteLine("XL = " & XL & " Ohms")
        Console.WriteLine("XC = " & XC & " Ohms")
        Console.WriteLine("R = " & R & " Ohms")
        Console.WriteLine("X = " & X & " Ohms")
        Console.WriteLine("Zt = " & Zt & " | " & T & "°")
        If X > 0 Then
            Console.WriteLine("Es un circuito inductivo")
        ElseIf X < 0 Then
            Console.WriteLine("Es un circuito capacitivo")
        Else
            Console.WriteLine("Es un circuito resistivo")
        End If
        Console.Write("Frecuencia de Resonancia = " & fr & " Hz")
    End Sub
End Module
