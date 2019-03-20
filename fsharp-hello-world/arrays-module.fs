module Module3

let arr = [| 1; 2; 4; |]

let fruits = [|
    "apple"
    "orange"
    "pear"
|]

let numbers = [|1..99|]

let numbersStep = [|1..5..99|]

let squares = [| for i in 0..99 do yield i * i|]

let RandomFruits count =
    let r = System.Random()
    let fruits = [|"apple";"orange";"pear"|]
    [|
        for i in 1..count do
            let index = r.Next(3)
            yield fruits.[index]
    |]