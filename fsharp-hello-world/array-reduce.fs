module ArrayReduce

open System
String.Join(", ", [| "aaa"; "bbb"; "ccc" |])


let ReduceDemo arr = 
    arr
    |> Array.reduce (fun acc elem -> sprintf "%s, %s" acc elem)