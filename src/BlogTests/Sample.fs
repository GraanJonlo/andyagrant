module Tests

open Expecto
open Suave

let withUri u hc =
    let uri = new System.Uri("http://some.random.tld" + u)
    let rawQuery = uri.Query.TrimStart('?')
    let req =
        {
            hc.request with
                url = uri
                rawQuery = rawQuery
        }
    {
        hc with
            request = req
    }

let asGetRequest hc =
    let req = { hc.request with ``method`` = HttpMethod.GET }
    {
        hc with request = req
    }

let getRequest u =
    HttpContext.empty
    |> withUri u
    |> asGetRequest

let expectSome hc =
    match hc with
    | Some x -> x
    | None -> Tests.failtest "No context"

let extractContext ashc =
    ashc |> Async.RunSynchronously |> expectSome

let extractStatus hc =
    hc.response.status

[<Tests>]
let tests =
    testList "samples" [
        testCase "smoke test" <| fun _ ->
            let status =
                getRequest "/"
                |> Blog.App.webPart
                |> extractContext
                |> extractStatus
            Expect.equal status.code HTTP_200.code "Smoke test should give 200 response"
    ]
