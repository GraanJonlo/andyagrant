namespace Blog

module App =
    open Suave
    open Suave.Filters
    open Suave.Operators
    open Suave.Successful

    let html container = OK (View.index container)

    let webPart =
        choose [
            path Path.home >=> html View.posts
            path Path.Posts.all >=> html View.posts
            pathScan Path.Posts.post (View.post >> html)
            pathRegex "(.*)\.(css|jpg|js|png|svg)" >=> Files.browseHome
        ]
        