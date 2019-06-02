module ArrayZip

let ArrayMultiply arr1 arr2 =
    Array.zip arr1 arr2
    |> Array.map (fun (x, y) -> x * y)

// > ArrayMultiply [| 1; 2; 3 |] [| 2; 2; 2 |];; 
// val it : int [] = [|2; 4; 6|]