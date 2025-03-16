using ApiClient.Refit.Cep;
using ApiClient.Refit.Cnpj;
using ApiClient.Refit.DDD;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRefitClient<ICepRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://brasilapi.com.br");
});
builder.Services.AddRefitClient<ICnpjRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://brasilapi.com.br");
});
builder.Services.AddRefitClient<IDddRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://brasilapi.com.br");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
