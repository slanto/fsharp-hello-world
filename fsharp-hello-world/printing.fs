module PrintingDemo
open System 

// tuple printing
let t = (1,2)
Console.WriteLine("A tuple: {0}", t)
printfn "A tuple: %A" t    

// record printing
type Person = {First:string; Last:string}
let johnDoe = {First="John"; Last="Doe"}
Console.WriteLine("A record: {0}", johnDoe )
printfn "A record: %A" johnDoe 

// union types printing
type Temperature = 
    | F of int 
    | C of int

let freezing = F 32

Console.WriteLine("A union: {0}", freezing )
printfn "A union: %A" freezing 