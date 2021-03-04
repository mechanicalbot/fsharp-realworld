namespace RealWorld.Api.Controllers

open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("[controller]")>]
type UsersController() =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() = [| "a"; "b" |]
