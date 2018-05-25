namespace Blog

module Path =
    type StringPath = PrintfFormat<(string -> string), unit, string, string, string>

    let home = "/"

    module Posts =
        let all = "/posts"
        let post : StringPath = "/posts/%s"