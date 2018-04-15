namespace Blog

open Suave
open Suave.Operators
open Suave.Successful

module App =
    let helloWorld =
        fun (ctx : HttpContext) ->
            OK "Hello World from Suave" ctx