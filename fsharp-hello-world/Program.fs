open System
// Learn more about F# at http://fsharp.org

let SayHello() = 
    printfn "Hello"

let PrintNumbers min max =
    let square n = 
        n * n
    for x in min..max do
        printfn "%i %i" x (square x)

let possition = 1.2, 3.9

let RandomPossition()=
    let r = System.Random();
    r.NextDouble(), r.NextDouble()
    
let Area length height =
    length * height

[<EntryPoint>]
let main argv =
    SayHello()
    PrintNumbers 1 20
    let latitude, longitude = RandomPossition();
    0 // return an integer exit code
