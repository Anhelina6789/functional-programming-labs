module Recursion

// Рекурсивна функція факторіалу
// Чиста функція: результат залежить лише від n, без побічних ефектів
let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)

// Рекурсивна функція суми списку
// Чиста функція: не змінює список і не використовує зовнішній стан
let rec sumList list =
    match list with
    | [] -> 0
    | head :: tail -> head + sumList tail
