module Module4

//Record types
type Person = 
    {
         FirstName : string
         LastName : string   
    }

let person = {FirstName = "Kelly"; LastName = "Melly"}

printfn "%s, %s" person.FirstName person.LastName

// cannot modify record. always new record is created
let person2 = { person with FirstName = "Monica"}

//Structural equality == content equality 
let person3 = {FirstName = "Kelly"; LastName = "Melly"}
let areEquals = person = person3

//Option type

type Company = 
    {
        Name : string
        SalesTaxNumber : int option      
    }

let company1 = { Name = "Ball Enterprise"; SalesTaxNumber = None }
let company2 = { Name = "Axy Dot"; SalesTaxNumber = Some 1234}

let PrintCompany (company : Company) =
    let taxNumberString =
        match company.SalesTaxNumber with
        | Some n -> sprintf " [%i]" n
        | None -> ""
    printfn "%s%s" company.Name taxNumberString

//Discriminated Unions -> we don't need type hierarchy just DUs

type Shape =
    | Square of float
    | Rectangle of float * float
    | Circle of float

let s = Square 3.4
let r = Rectangle (2.2, 1.9)
let c = Circle 1.0

let drawing = [| s; r; c|]

// Pattern matching
let Area (shape : Shape) =
    match shape with
    | Square x -> x * x
    | Rectangle (h, w) -> h * w
    | Circle r -> System.Math.PI * r * r

let one = [|50|]
let two = [|60;61|]
let many = [|0..90|]

let Describe arr =
    match arr with
    | [|x|] -> sprintf "One element: %i" x
    | [|x; y|] -> sprintf "Two elements: %i %i" x y
    | _ -> sprintf "A longer array"