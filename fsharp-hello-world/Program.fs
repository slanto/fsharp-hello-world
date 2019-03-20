// Learn more about F# at http://fsharp.org


let SayHello() = 
    printfn "Hello"

let PrintNumbers min max =
    let square n = 
        n * n
    for x in min..max do
        printfn "%i %i" x (square x)

[<EntryPoint>]
let main argv =
    SayHello()
    PrintNumbers 1 20
    0 // return an integer exit code
