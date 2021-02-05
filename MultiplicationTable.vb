Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim firstDimension As Integer
        Dim secondDimension As Integer
        Dim problem As Boolean = True

        While problem = True And userInput <> "Q" And userInput <> "q"
            Try
                Console.WriteLine("please enter the first dimension of the table")
                userInput = Console.ReadLine()
                firstDimension = CInt(userInput)
                problem = False
            Catch ex As Exception
                Console.WriteLine("please enter a whole number")
            End Try
        End While

    End Sub

End Module
