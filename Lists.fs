module Lists

// чиста функція:
// бере список, не змінює зовнішній стан,
// використовує тільки filter + map + sum
let sumOfSquaresOfEven (numbers: int list) : int =
    numbers
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * x)
    |> List.sum
