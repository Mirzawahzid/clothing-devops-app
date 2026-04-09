var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // ✅ MUST be there
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers(); // ✅ MUST be there

app.Run();