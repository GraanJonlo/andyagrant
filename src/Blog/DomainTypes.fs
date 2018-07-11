namespace Blog

module DomainTypes =
    open NodaTime

    type YoutubePost =
        {
            PostId: string
            Title: string
            YoutubeId: string
            Description: string
            Timestamp: LocalDate
        }
    
    type VideoPost =
        | YoutubePost of YoutubePost
    
    type Post =
        | VideoPost of VideoPost

    type PostSummary =
        {
            PostId: string
            Title: string
            Image: string
            Placeholder: string
            Summary: string
            Timestamp: LocalDate
        }

