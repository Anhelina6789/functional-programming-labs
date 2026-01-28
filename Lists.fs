module Lists
// початковий список чисел від 1 до 10
let numbers = [1..10]
// список квадратів
let squares = numbers |> List.map (fun x -> x * x)
// тільки парні числа
let evenNumbers = numbers |> List.filter (fun x -> x % 2 = 0)
// сума елементів
let sumOfNumbers = numbers |> List.sum
