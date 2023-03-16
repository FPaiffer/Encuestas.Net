using Encuestas.Net.Presentation;
using Encuestas.Net.Presentation.Services;
using Encuestas.Net.Presentation.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7162/") });
builder.Services.AddScoped<ISurveyService, SurveyService>();
builder.Services.AddScoped<IRespondentService, RespondentService>();
builder.Services.AddScoped<IRespondentResponseService, RespondentResponseService>();
await builder.Build().RunAsync();
