namespace RealWorld.Api.Controllers

open Microsoft.AspNetCore.Mvc
open RealWorld.Api.Responses



[<ApiController>]
[<Route("[controller]")>]
type TagsController() =
    inherit ControllerBase()

    [<HttpGet>]
    member this.GetTags(): ActionResult<TagsResponse> =
        let inline (!>) (x:^a) : ^b = ((^a or ^b) : (static member op_Implicit : ^a -> ^b) x) 

        !> this.Ok({ tags = [||] })
