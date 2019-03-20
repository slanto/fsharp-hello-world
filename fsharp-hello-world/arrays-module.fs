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

let isEven n = 
        n % 2 = 0

let RandomFruits count =
    let r = System.Random()
    let fruits = [|"apple";"orange";"pear"|]
    [|
        for i in 1..count do
            let index = r.Next(3)
            yield fruits.[index]
    |]

let RandomFruits2 count =
    let r = System.Random()
    let fruits = [|"apple";"orange";"pear"|]
    Array.init count (fun _ -> 
        let index = r.Next(3)
        fruits.[index]
    )

let LikeSomeFruits fruits =
        for fruit in fruits do
                printfn "I like %s" fruit

let evenSquares = Array.filter (fun x -> isEven x) squares

let sortedFruits = Array.sort [| "pear"; "orange"; "apple"|]

let PrintLongWords (words: string[]) =
        let longWords : string [] = Array.filter (fun w -> w.Length > 8) words
        let sortedLongWords = Array.sort longWords
        Array.iter (fun w -> printfn "%s" w) sortedLongWords

let PrintLongWords2 (words: string[]) =
        words 
        |> Array.filter (fun w -> w.Length > 4)
        |> Array.sort
        |> Array.iter (fun w -> printfn "%s" w)

let PrintSquares min max =
        let square n =
                n * n
        [|min..max|]
        |> Array.map (fun i-> square i)
        |> Array.iter (fun s -> printfn "%i" s)

let arr2 = [|1..10|]

arr2.[2] <- 100 // array is mutable. I can its change in index 2 

let PrintNumbersLessThenFive min max =
        [min..max] // <- list is immutable
        |> List.filter (fun n -> n < 5)
        |> List.iter (fun i -> printfn "%i" i)


// Sequences === IEnumerable in c#
let smallNumbers = {1..99}

let smallNumbers2 = Seq.init 100 (fun i -> i)

let smallNumbers3 = 
        seq {
                for i in 0..99 do
                        yield i
        }

open System.IO
let bigFiles =
        Directory.EnumerateFiles(".")
        |> Seq.map (fun name -> FileInfo name)
        |> Seq.filter (fun fi -> fi.Length > 10L)
        |> Seq.map (fun fi -> fi.Name)