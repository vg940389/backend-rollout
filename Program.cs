var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => "Hello, KubeRocketCI v2 from $HOSTNAME");

app.Run();


