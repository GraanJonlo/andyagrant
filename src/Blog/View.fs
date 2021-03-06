namespace Blog

module View =
    open Suave.Html
    open System.Globalization

    open DomainTypes

    let h1 = tag "h1"
    let h2 = tag "h2"
    let figure = tag "figure"
    let footer = tag "footer"
    let header = tag "header"
    let iframe = tag "iframe"
    let nav = tag "nav"
    let section = tag "section"
    let time = tag "time"

    let cssLink href =
        link [
            "href", href
            "rel", "stylesheet"
            "type", "text/css" ]

    let navMenu =
        div [] [
            nav ["class", "navbar"] [
                div ["class", "navbar-menu"] [
                    div ["class", "navbar-start"] [
                        a Path.home ["class", "navbar-item"] [Text "Home"]
                    ]
                ]
            ]
        ]

    let index container =
        html [] [
            head [] [
                title [] "Home"
                cssLink "https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.1/css/bulma.min.css"
                cssLink "https://fonts.googleapis.com/css?family=Montserrat:600|Roboto"
                cssLink "/css/site.css"
            ]

            body [] [
                div [] [
                    section ["class", "hero is-primary"] [
                        div ["class", "hero-body"] [
                            div ["class", "container"] [
                                header [] [
                                    h1 ["class", "title"] [
                                        a Path.home [] [Text "Andy Grant"]
                                    ]
                                    h2 ["class", "subtitle"] [
                                        Text "Programming and gaming in Manchester UK"
                                    ]
                                    navMenu
                                ]
                            ]
                        ]
                    ]

                    section ["class", "section"] container

                    footer ["class", "footer"] [
                        div ["class", "container"] [
                            div ["class", "content has-text-centered"] [
                                p [] [Text "It's a footer! 2018-04-22T09:04"]
                            ]
                        ]
                    ]
                ]
            ]
            script [ "type", "text/javascript"; "src", "/scripts/lazy.js" ] []
        ]
        |> htmlToString
    
    let videoCard post =
        div ["class", "card"] [
            a (sprintf Path.Posts.post post.PostId) [] [
                div ["class", "card-image"] [
                    figure ["class", "image is-16by9"] [
                        img [
                            "src",post.Placeholder
                            "data-large",post.Image
                            "class","imgPlaceholder"
                            "alt",post.Title
                        ]
                    ]
                ]
            ]
            div ["class","card-content"] [
                h2 ["class","title is-4"] [
                    Text post.Title
                ]
                div ["class","content"] [
                    Raw post.Summary
                ]
                p [] [
                    time ["dateTime", post.Timestamp.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)] [
                        Text <| post.Timestamp.ToString()
                    ]
                ]
            ]
        ]
    
    let column x = div ["class","column"] [x]

    let columnOfLength len x =
        List.map column x
        |> Common.rightPad len (div ["class","column"] [])

    let latestRow row =
        let latestCol' x = div ["class", "column is-half"] [x]

        div ["class", "columns"]
            (match row with
            | head :: tail -> (latestCol' head) :: columnOfLength 2 tail
            | [] -> [])
    
    let makeRow row =
        columnOfLength 4 row
        |> div ["class", "columns"]
    
    let makeRows cards =
        let rec makeRows' state list =
            match list with
            | [] -> List.rev state
            | _ ->
                let row =
                    List.truncate 4 list
                    |> makeRow
                if List.length list > 4 then
                    makeRows' (row :: state) (List.skip 4 list)
                else
                    makeRows' (row :: state) []
        
        let topRow =
            cards
            |> List.truncate 3
            |> latestRow
        
        if List.length cards > 3 then
            makeRows' [topRow] (List.skip 3 cards)
        else
            [topRow]
    
    let youtubePost (post:YoutubePost) =
        [
            div ["class","container"] [
                h1 ["class","title"] [Text post.Title]
                iframe [
                    "width", "560"
                    "height", "315"
                    "src", "https://www.youtube.com/embed/" + post.YoutubeId
                    "frameborder", "0"
                    "allow", "autoplay; encrypted-media"
                    "allowfullscreen", "true"] []
                div [] [
                    Raw post.Description
                ]
            ]
        ]

    let posts allPosts =
        let postSummaries =
            allPosts
            |> List.map videoCard

        [
            div ["class","container"]
                (makeRows postSummaries)
        ]
