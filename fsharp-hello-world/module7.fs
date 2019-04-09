module Library1

let add1 x = x + 1

// currying
let printTwoParameters x y =
    printfn "x=%i y=%i" x y

let explicitlyCurriedVersionOfPrintingTwoParameters x =
    let subFunction y =
        printfn "x=%i y=%i" x y
    subFunction


//normal version
let addTwoParameters x y = 
   x + y

//explicitly curried version
let addTwoParameters' x  =      // only one parameter!
   let subFunction y = 
      x + y                    // new function with one param
   subFunction                 // return the subfunction

// now use it step by step 
let x = 6
let y = 99
let intermediateFn = addTwoParameters' x  // return fn with 
                                         // x "baked in"
let result  = intermediateFn y 

// normal version
let result'  = addTwoParameters x y