var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var html = System.IO.File.ReadAllText("/Users/jessiedaniel/Projects/HTML &CSS/HTML &CSS/Index.html");
    return html;
});


app.Run();

