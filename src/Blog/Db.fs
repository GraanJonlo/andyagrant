namespace Blog

module Db =
    open NodaTime

    open DomainTypes

    let allPosts () =
        [
            // VideoPost (
            //     {
            //         postId="xpman061.6"
            //         title="XPMan 61.6 - Bug Free Code"
            //         summary="<p>Gemma Cameron at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            //         timestamp=LocalDate(2015,7,9)
            //     },
            //     {
            //         url="https://youtu.be/ps9GA7DkKQc"
            //         image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.jpg"
            //         placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.6.svg"
            //         recorded=LocalDate(2015,7,9)
            //     })
            // VideoPost (
            //     {
            //         postId="xpman061.5"
            //         title="XPMan 61.5 - Abstractions"
            //         summary="<p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            //         timestamp=LocalDate(2015,7,9)
            //     },
            //     {
            //         url="https://youtu.be/9LtstaVN-KA"
            //         image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.jpg"
            //         placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.5.svg"
            //         recorded=LocalDate(2015,7,9)
            //     })
            // VideoPost (
            //     {
            //         postId="xpman061.4"
            //         title="XPMan 61.4 - Collaboration"
            //         summary="<p>Clare Sudbery at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
            //         timestamp=LocalDate(2015,7,9)
            //     },
            //     {
            //         url="https://youtu.be/Geia8E3hBIw"
            //         image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.jpg"
            //         placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.4.svg"
            //         recorded=LocalDate(2015,7,9)
            //     })
            VideoPost (
                {
                    postId="xpman061.3"
                    title="XPMan 61.3 - Hidden Queues"
                    summary="<p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
                    timestamp=LocalDate(2015,7,9)
                },
                {
                    url="https://youtu.be/mH0q_cBd144"
                    image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.jpg"
                    placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.3.svg"
                    recorded=LocalDate(2015,7,9)
                })
            VideoPost (
                {
                    postId="xpman061.2"
                    title="XPMan 61.2 - Microservices"
                    summary="<p>Nima Montazeri at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
                    timestamp=LocalDate(2015,7,9)
                },
                {
                    url="https://youtu.be/1gigc-7Fv_I"
                    image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.jpg"
                    placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.2.svg"
                    recorded=LocalDate(2015,7,9)
                })
            VideoPost (
                {
                    postId="xpman061.1"
                    title="XPMan 61.1 - We Said It Would Be Simple, Not Easy"
                    summary="<p>Andy Longshaw at the Extreme Programming Manchester 2015 Lightning Talks.</p>"
                    timestamp=LocalDate(2015,7,9)
                },
                {
                    url="https://youtu.be/ps9GA7DkKQc"
                    image="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.jpg"
                    placeholder="https://d20sprsywyfv7z.cloudfront.net/images/xpman061.1.svg"
                    recorded=LocalDate(2015,7,9)
                })
        ]