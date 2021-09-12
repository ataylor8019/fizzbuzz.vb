' Fizzbuzz solution:
' Common problem statement is to test all numbers from 1 to 100, and if the
' number is a multiple of 3, to print the word "fizz", and if the number is
' a multiple of 5, to print the word "buzz". If the number is a multiple of
' both, then the program should print the word "fizzbuzz". Otherwise, print
' out the number.
' 
' Allan Taylor
' 09/09/2021


Module Module1

    Sub Main()

        For i As Integer = 1 To 100

            ' i mod 3 AND i mod 5 having a false value means this number is not
            ' a multiple of either, therefore print the number.
            ' Note that a boolean test must be explicitly done to produce testable
            ' boolean values, as opposed to c, which only requires the values be 
            ' non-zero to satisfy truth testing.
            ' Also note that in Visual Basic, truth = -1, and false = 0
            If ((i Mod 3 > 0) And (i Mod 5 > 0)) Then    ' Most common scenario, is placed first.
                Console.WriteLine(i.ToString())
                Continue For    ' No need to test more factors, go to the next iteration of the loop.
            End If

            ' Inverting i mod 3's > 0 output results in "true" for factors of 3
            ' (i mod 3 for factors of 3 equals 0).
            ' Note that taking the non-inverted value of i mod 3 is equal to zero
            ' would have produced an equally true truth value.
            If Not (i Mod 3 > 0) Then Console.Write("fizz")    ' Second most common scenario, is placed second.

            ' The previous logic applies to the output of i mod 5 > 0 as well.
            If Not (i Mod 5 > 0) Then Console.Write("buzz")    ' Third most common scenario, is placed last.


            Console.Write(vbNewLine)    ' No test for factors of 3 and 5 simultaneously is needed

            ' If a number is a factor of 3 and 5, the execution will fall 
            ' through both of the if statements starting at line 33. As no end
            ' of line character (vbNewLine) is printed in either if statement, and
            ' because the test for being a factor of 3 is always done before the
            ' test for being a factor of 5, the resulting output is "fizzbuzz".
            ' 
            ' If a number is only a factor of 3 or only a factor of 5, the
            ' respective word will be printed, and the alternate if case ignored.
            ' In all cases where i is a factor of 3, 5, or both, the end of line 
            ' character is printed after the determination is made, allowing the
            ' calculation as to what text to print to be as short as possible
        Next

        Console.Read()    'Needs to be here to prevent the program window from immediately closing.
    End Sub

End Module
