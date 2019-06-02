module PatternMatching

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