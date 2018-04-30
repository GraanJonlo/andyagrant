namespace Blog

module DomainTypes =
    open NodaTime

    type PostSummary =
        {
            postId: string
            title: string
            image: string
            placeholder: string
            summary: string
            timestamp: LocalDate
        }

