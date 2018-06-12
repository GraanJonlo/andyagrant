namespace Blog

module App =
    open Suave
    open Suave.Filters
    open Suave.Operators
    open Suave.RequestErrors
    open Suave.Successful

    let html container = OK (View.index container)

    let allPosts = Db.postSummaries () |> View.posts |> html

    let getPost id =
        match Db.post id with
        | Some p -> View.post p |> html
        | None -> NOT_FOUND "Nope"

    let webPart =
        choose [
            path Path.home >=> allPosts
            path Path.Posts.all >=> allPosts
            pathScan Path.Posts.post getPost
            pathRegex "(.*)\.(css|jpg|js|png|svg)" >=> Files.browseHome
        ]
        