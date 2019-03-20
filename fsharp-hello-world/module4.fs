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