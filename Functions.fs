module Functions

// Чиста функція: результат залежить тільки від аргументу
let square x = x * x

// Чиста функція: не має побічних ефектів
let absValue x =
    if x < 0 then -x else x

// Чиста функція: не змінює зовнішній стан
let maxOfTwo a b =  
    if a > b then a else b
