module ArrayChoose

open System.Net

let GetRequests () =
    let requests = [|
        "http://www.google.com"
        "http://www.pluralsight.com"
        "http://99.99.99.99/doesnotexit"
    |]

    use wc = new WebClient()

    requests
    |> Array.map (fun url ->
        try 
            wc.DownloadString(url) |> Some
        with 
        | _ -> None)
    |> Array.filter (fun s -> s.IsSome)
    |> Array.map (fun s-> s.Value)
    |> Array.iter (fun s-> printfn "Content %s" (s.Trim().Substring(0, 100)))      


let GetRequests2 () =
    let requests = [|
        "http://www.google.com"
        "http://www.pluralsight.com"
        "http://99.99.99.99/doesnotexit"
    |]

    use wc = new WebClient()

    requests
    |> Array.choose (fun url ->
        try 
            wc.DownloadString(url) |> Some
        with 
        | _ -> None)
    |> Array.iter (fun s-> printfn "Content %s" (s.Trim().Substring(0, 100)))      