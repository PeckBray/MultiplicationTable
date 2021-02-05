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
                If userInput <> "Q" Then

                ElseIf userInput <> "q" Then

                Else
                    Console.WriteLine("please enter a whole number")
                    problem = True
                End If

            End Try
        End While

        problem = True

        While problem = True And userInput <> "Q" And userInput <> "q"
            Try
                Console.WriteLine("please enter the second dimension of the table")
                userInput = Console.ReadLine()
                secondDimension = CInt(userInput)
                problem = False
            Catch ex As Exception
                If userInput <> "Q" Then

                ElseIf userInput <> "q" Then

                Else
                    Console.WriteLine("please enter a whole number")
                    problem = True
                End If

            End Try
        End While

        Dim table(firstDimension, secondDimension) As Integer

        For i = 1 To firstDimension
            For j = 1 To secondDimension

                table(i, j) = i * j
                Console.Write($"{table(i, j)}")
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

End Module
