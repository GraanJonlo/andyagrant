namespace Blog

module DomainTypes =
    open NodaTime

    type PostSummary =
        {
            PostId: string
            Title: string
            Image: string
            Placeholder: string
            Summary: string
            Timestamp: LocalDate
        }

