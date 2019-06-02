module ArrayFold 

open System

let FoldDemo separator arr =
    arr
    |> Array.fold (fun acc elem -> sprintf "%s%s%s" acc elem separator) separator


