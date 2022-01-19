Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim name As String 'defines a string variable
        Console.WriteLine("Name: ") 'writes the prompt for the user to input name

        name = Console.ReadLine() 'Sets the value input to the String variable "name"

        Console.WriteLine("Hello " & name & ", my name is Tom Riddle. How did you get this diary?")
        Console.ReadLine() 'Sends a response addressing the input string
    End Sub

End Module
