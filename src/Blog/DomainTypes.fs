namespace Blog

module DomainTypes =
    open NodaTime

    type Video =
        {
            url:string
            image:string
            placeholder:string
            recorded:LocalDate
        }
    
    type Post =
        {
            postId:string
            title:string
            summary:string
            timestamp:LocalDate
        }
    
    type BlogPost =
    | VideoPost of Post * Video
