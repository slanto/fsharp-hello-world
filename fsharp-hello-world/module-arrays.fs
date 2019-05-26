module ArraysDemo

// Create array from a literal
let primes = [|1; 3; 5; 7|]
let animals = [|
    "cat"
    "dog"
    "frog"
|]

// from a comprehension
let someNumbers = [|1000..1020|]
let smallEvents = [| for i in 1..100 do
                        if i % 2 = 0 then yield i|]
                       
// from the Array module
let notUseful = Array.create 10 "hello world"

let emptyString : string[] = Array.zeroCreate 100

open System

let lastDay year =
    Array.init 12 (fun i -> 
        let month = i+1
        let firstDay = DateTime(year, month, 1)
        let lastDay = firstDay.AddDays(float(DateTime.DaysInMonth(year, month)-1))
        lastDay
    )