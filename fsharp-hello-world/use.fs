module UseDemo

open System.IO

let readAFile () =
    use reader = new StreamReader(
                                     __SOURCE_DIRECTORY__ + "\\test.txt")
    reader.ReadToEnd()
    
readAFile()
|> ignore

