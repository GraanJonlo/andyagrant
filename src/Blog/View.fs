namespace Blog

module View =
    open Suave.Html

    let post id = [Text (sprintf "Post %s" id)]
    let posts = [Text "Posts"]

    let h1 = tag "h1"
    let h2 = tag "h2"
    let footer = tag "footer"
    let header = tag "header"
    let nav = tag "nav"
    let section = tag "section"

    let cssLink href = link [ "href", href; " rel", "stylesheet"; " type", "text/css" ]

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
        ]
        |> htmlToString