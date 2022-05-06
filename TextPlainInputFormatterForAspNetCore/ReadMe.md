Packaged version of the code from https://peterdaugaardrasmussen.com/2020/02/29/asp-net-core-how-to-make-a-controller-endpoint-that-accepts-text-plain/

register the formatter with

```
using TextPlainInputFormatterForAspNetCore;

builder.Services.AddControllers(o => o.InputFormatters.Insert(o.InputFormatters.Count, new TextPlainInputFormatter()));
```

in the controller, use this with

```
[HttpPost("TryItOut")]
[Consumes("text/plain")]
public string TryItOut([FromBody] string body)
{
    return body;
}
```