var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure a route for serving HTML content
app.MapGet("/", context =>
{
    context.Response.ContentType = "text/html";
    return context.Response.WriteAsync(@"
        <!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>My Web Application</title>
            <style>
                body {
                    font-family: Arial, sans-serif;
                    background-color: #f0f0f0;
                    text-align: center;
                    padding: 20px;
                }

                h1 {
                    color: #333;
                }

                .container {
                    background-color: #fff;
                    padding: 20px;
                    border-radius: 8px;
                    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                    margin-top: 20px;
                }
            </style>
        </head>
        <body>
            <h1>Welcome to My Web Application</h1>
            <div class='container'>
                <p>This is a simple web application built with ASP.NET Core and build using Jenkins pipeline.</p>
                <ul>
                    <li>Item 1</li>
                    <li>Item 2</li>
                    <li>Item 3</li>
                </ul>
            </div>
        </body>
        </html>
    ");
});

app.Run();
