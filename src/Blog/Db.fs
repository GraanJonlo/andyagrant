namespace Blog

module Db = 
    open NodaTime

    open DomainTypes

    let post id =
        Some
          { PostId = "xpman063"
            Title = "XPMan 63 - Microservices Debate"
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.svg"
            Content = "<p>Microservices seem to be a hot topic at the moment driven by companies such as Netflix and Spotify but are they always the right solution?</p>"
            Timestamp = LocalDate(2015,9,10) }

    let postSummaries () =
        [ { PostId = "xpman063"
            Title = "XPMan 63 - Microservices Debate"
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.svg"
            Summary = "<p>Microservices seem to be a hot topic at the moment driven by companies such as Netflix and Spotify but are they always the right solution?</p>"
            Timestamp = LocalDate(2015,9,10) }
          { PostId = "xpman062"
            Title = "XPMan 62 - In Defence of Mocks, with Mark Kirschstein"
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman062.0.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman062.0.svg"
            Summary = "<p>Are mocks pointless? This session argues maybe, maybe not...</p>"
            Timestamp = LocalDate(2015,8,13) }
          { PostId = "xpman061.6"
            Title = "XPMan 61.6 - Bug Free Code"
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.svg"
            Summary = "<p>Gemma Cameron at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9) }
          { PostId = "xpman061.5"
            Title = "XPMan 61.5 - Abstractions"
            Summary = "<p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9)
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.svg" }
          { PostId = "xpman061.4"
            Title = "XPMan 61.4 - Collaboration"
            Summary = "<p>Clare Sudbery at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9)
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.svg" }
          { PostId = "xpman061.3"
            Title = "XPMan 61.3 - Hidden Queues"
            Summary = "<p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9)
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.svg" }
          { PostId = "xpman061.2"
            Title = "XPMan 61.2 - Microservices"
            Summary = "<p>Nima Montazeri at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9)
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.svg" }
          { PostId = "xpman061.1"
            Title = "XPMan 61.1 - We Said It Would Be Simple, Not Easy"
            Summary = "<p>Andy Longshaw at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            Timestamp = LocalDate(2015,7,9)
            Image = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.jpg"
            Placeholder = "https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.svg" } ]
