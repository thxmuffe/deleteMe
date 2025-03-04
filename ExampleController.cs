using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Tässä lisätty luokalle ExampleController attribuutti,
// joka kertoo builder.Services.AddControllers(), että
// tämä luokka tulee configuroida mukaan build webb app processissa...

[ApiController]
class ExampleController {

    [HttpGet("/index")]
    public async Task<ActionResult<string>> Moi() {
        return "MOI";
    }


}