using Microsoft.AspNetCore.Mvc;

namespace repro.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    [HttpGet]
    public int MakesAnalyzerThrow() => throw new NotImplementedException();

    [HttpGet("a")]
    public int DoesNotMakeAnalyzerThrow()
    {
        if (false) return 1;

        throw new NotImplementedException();
    }
}
