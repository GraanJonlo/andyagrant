namespace Blog

module Db =
    open NodaTime

    open DomainTypes

    let postSummaries () =
        [ { postId="xpman063"
            title="XPMan 63 - Microservices Debate"
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman063.0.svg"
            summary="<p>Microservices seem to be a hot topic at the moment driven by companies such as Netflix and Spotify but are they always the right solution?</p>"
            timestamp=LocalDate(2015,9,10) }
          { postId="xpman062"
            title="XPMan 62 - In Defence of Mocks, with Mark Kirschstein"
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman062.0.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman062.0.svg"
            summary="<p>Are mocks pointless? This session argues maybe, maybe not...</p>"
            timestamp=LocalDate(2015,8,13) }
          { postId="xpman061.6"
            title="XPMan 61.6 - Bug Free Code"
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.svg"
            summary="<p>Gemma Cameron at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9) }
          { postId="xpman061.5"
            title="XPMan 61.5 - Abstractions"
            summary="<p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9)
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.svg" }
          { postId="xpman061.4"
            title="XPMan 61.4 - Collaboration"
            summary="<p>Clare Sudbery at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9)
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.svg" }
          { postId="xpman061.3"
            title="XPMan 61.3 - Hidden Queues"
            summary="<p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9)
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.svg" }
          { postId="xpman061.2"
            title="XPMan 61.2 - Microservices"
            summary="<p>Nima Montazeri at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9)
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.svg" }
          { postId="xpman061.1"
            title="XPMan 61.1 - We Said It Would Be Simple, Not Easy"
            summary="<p>Andy Longshaw at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            timestamp=LocalDate(2015,7,9)
            image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.jpg"
            placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.svg" } ]
