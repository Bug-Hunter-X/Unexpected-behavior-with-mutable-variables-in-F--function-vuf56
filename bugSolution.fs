let x = 10
let y = 20

// Solution 1: Using tuples
let swap (x, y) = (y, x)
let x', y' = swap (x, y)
printf "%d %d" x' y' // this will print 20 10

// Solution 2: Using pattern matching
let swap2 x y = 
    match x, y with
    | a, b -> (b, a)

let x'', y'' = swap2 x y
printf "%d %d" x'' y'' // this will print 20 10