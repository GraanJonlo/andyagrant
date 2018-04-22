namespace Blog

module Common =
    let rightPad length padding collection =
        let rec pad' length padding collection =
            if List.length collection >= length then
                List.rev collection
            else
                padding :: collection
                |> pad' length padding
        
        List.rev collection
        |> pad' length padding