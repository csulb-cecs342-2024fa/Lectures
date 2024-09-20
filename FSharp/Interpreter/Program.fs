﻿open System

// This is a very basic math interpreter, using unions to discriminate between 
// expression operators.


// An expression is either a constant value, or an arithmetic function applied to
// one or more operands that are expressions.
type Expression = 
    | Const of float
    | Add of Expression * Expression
    | Sub of Expression * Expression

   
// evaluate converts an Expression object into the floating-point number it represents.
let rec evaluate expr =
    match expr with 
    | Const c -> c
    | Add (expr1, expr2) -> (evaluate expr1) + (evaluate expr2)
    | Sub (expr1, expr2) -> (evaluate expr1) - (evaluate expr2)

// Ugly print the expression.
let demo1 = Sub (Add (Const 10, Const 3), Const 2)
printfn $"{demo1}"

// Evaluate and print the expression.
demo1
|> evaluate
|> printfn "%f" // prints the result of evaluating 10 + 3 - 2


