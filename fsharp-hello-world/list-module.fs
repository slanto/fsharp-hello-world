module ListDemo

let emptyList = []

let newList = [1;3;5]

// add 1 in front of newList
let list = 1 :: newList


//list concatenation
["a"; "b"] @ ["c"; "d"]
|> List.map (fun c-> printfn "%s" c)
|> ignore


