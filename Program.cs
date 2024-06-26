var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicionando o servi�o CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowLocalhost",
		builder => builder.WithOrigins("http://127.0.0.1:5173")
						  .AllowAnyMethod()
						  .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Aplicando a pol�tica CORS
app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
