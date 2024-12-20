let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // this will print 20 20

// The issue is that the swap function modifies the local copies of x and y, not the original variables passed to it.
// In F#, value types are immutable, so changes to x and y inside the swap function do not affect the original values outside.