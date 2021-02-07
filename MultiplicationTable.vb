'Brayden Peck
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/PeckBray/MultiplicationTable
Option Strict On
Option Explicit On
Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim firstDimension As Integer
        Dim secondDimension As Integer
        Dim problem As Boolean = True


        While problem = True And userInput <> "Q" And userInput <> "q"
            Try
                Console.WriteLine("Please Enter the First Dimension of the Table")
                userInput = Console.ReadLine()
                firstDimension = CInt(userInput)
                problem = False
            Catch ex As Exception
                If userInput <> "Q" Then

                ElseIf userInput <> "q" Then

                Else
                    Console.WriteLine("Please Enter a Whole Number")
                    problem = True
                End If

            End Try
        End While

        problem = True

        While problem = True And userInput <> "Q" And userInput <> "q"
            Try
                Console.WriteLine("Please Enter the Second Dimension of the Table")
                userInput = Console.ReadLine()
                secondDimension = CInt(userInput)
                problem = False
            Catch ex As Exception
                If userInput <> "Q" Then

                ElseIf userInput <> "q" Then

                Else
                    Console.WriteLine("Please Enter a Whole Number")
                    problem = True
                End If

            End Try
        End While

        Dim table(firstDimension, secondDimension) As Integer

        Console.Clear()
        Console.WriteLine($"Enjoy your {firstDimension} x {secondDimension} Multiplication Table")

        For i = 1 To firstDimension
            For j = 1 To secondDimension

                table(i, j) = i * j
                Console.Write($"{table(i, j)}".PadLeft(6))
            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub

End Module
