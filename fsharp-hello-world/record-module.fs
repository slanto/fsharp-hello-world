module RecordModule

type Person = { Name: string; Age: int } with
        member this.CanDrive =
                    this.Age > 18
        member this.GreaterThen age =
                    age > this.Age
        
let bob = {Name = "Bob"; Age = 55}

let canDrive = bob.CanDrive
let isGreaterThen = bob.GreaterThen 12

// update bob with new age
let bob' = {bob with Age = 19}

