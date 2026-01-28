module Functions
// Чиста функція: результат залежить тільки від аргументу,
// не має побічних ефектів і не змінює зовнішній стан
let square (x: int) : int =
    x * x
// Чиста функція: для однакового x завжди повертає один результат
let absValue (x: int) : int =
    if x < 0 then -x else x
// Чиста функція: не використовує і не змінює зовнішні змінні
let maxOfTwo (a: int) (b: int) : int =
    if a > b then a else b
