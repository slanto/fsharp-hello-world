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

//Discriminated Unions