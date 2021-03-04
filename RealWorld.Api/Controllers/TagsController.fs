namespace RealWorld.Api.Controllers

open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("[controller]")>]
type TagsController() =
    inherit ControllerBase()

    [<HttpGet("array")>]
    member _.GetArray() = [| "a"; "b" |]

    [<HttpGet("list")>]
    member _.GetList() = [ "a"; "b" ]

    [<HttpGet("seq")>]
    member _.GetSeq() =
        seq {
            "a"
            "b"
        }
