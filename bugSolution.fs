let add x y = 
    let sum = x + y
    let yNew = y + sum
    sum + yNew

let x = 10
let y = 20

let result = add x y
printf "%d %d %d" x y result