namespace Blog

module DomainTypes =
    open NodaTime

    type Post =
        {
            PostId: string
            Title: string
            Image: string
            Placeholder: string
            Content: string
            Timestamp: LocalDate
        }

    type PostSummary =
        {
            PostId: string
            Title: string
            Image: string
            Placeholder: string
            Summary: string
            Timestamp: LocalDate
        }

