open Functions
open Recursion
open Lists

printfn "square 5 = %d" (square 5)
printfn "absValue -10 = %d" (absValue -10)
printfn "maxOfTwo 7 3 = %d" (maxOfTwo 7 3)

printfn "factorial 5 = %d" (factorial 5)
printfn "sum [1; 2; 3] = %d" (sumList [1; 2; 3])
printfn "sum [10; -5; 7] = %d" (sumList [10; -5; 7])

printfn "sum of squares of even [1;2;3;4] = %d"
    (sumOfSquaresOfEven [1; 2; 3; 4])

printfn "sum of squares of even [10; -5; 7; 6] = %d"
    (sumOfSquaresOfEven [10; -5; 7; 6])
