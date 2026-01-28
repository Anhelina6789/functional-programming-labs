module Recursion

// Рекурсивна чиста функція обчислення факторіалу
// чиста, бо залежить лише від аргументу n і не має побічних ефектів
let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)

// Рекурсивна чиста функція обчислення суми елементів списку
// не використовує цикли і не змінює зовнішній стан
let rec sumList list =
    match list with
    | [] -> 0
    | head :: tail -> head + sumList tail
