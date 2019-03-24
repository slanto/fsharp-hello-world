namespace Module6

//OO Type (class)

type Person(firstname : string, lastname : string) =
    member __.Firstname = firstname //insted of this. you can use __, self, etc.
    member __.Lastname = lastname

type MutablePerson(firstname : string, lastname : string) =
    member val Firstname = firstname with get, set
    member val Lastname = lastname with get, set


open System;

type SafePerson(firstname : string, lastname : string) =
    let validateString str =
        if String.IsNullOrWhiteSpace str then
            raise (ArgumentException())
    do
        validateString firstname
        validateString lastname
    member val Firstname = firstname with get, set
    member val Lastname = lastname with get, set    