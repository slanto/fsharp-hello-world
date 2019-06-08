module PatternMatching

let (a, b) = (1, 2)
printfn "a=%d b=%d" a b

let addPairs (a, b) =
    a + b

let addPair p =
    match p with
    | (f, 0) -> f
    | (0, s) -> s
    | (f, s) -> f + s

addPair (0, 2)
 |> printfn "%d"

type Scorecard = { Id: int; Score: decimal }

let scorecard = Some {Id = 1; Score = 25m}

let scorecardResult = match scorecard with
             | Some x -> sprintf "%A" x
             | None -> sprintf "Nothing"

let fizzbuzzer i =
    match i with
    | _ when i % 3 = 0 && i % 5 = 0 -> "fizzbuzz"
    | _ when i % 3 = 0 -> "fizz"
    | _ when i % 5 = 0 -> "buzz"
    | _ -> string i

[ 1..100 ]|> List.map fizzbuzzer|> ignore

// union types printing
type Temperature =
    | F of int
    | C of int

let freezing = F 32

let y = match freezing with
        | F i -> i
        | C b -> b
sprintf "%i" y
 |> ignore

let x =
    match 1 with
    | 1 -> "a"
    | 2 -> "b"
    | _ -> "z"

type IntOrBool =
    | I of int
    | B of bool

let intOrBool = B true
let result = match intOrBool with
                | I i -> i
                | B b -> b |> (fun v -> if v then 1 else 0)
