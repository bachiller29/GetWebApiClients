using AutoMapper;
using Client.WebApi.DTOS;
using Client.WebApi.Models;
using Client.WebApi.Services.Contract;
using Client.WebApi.Services.Implementation;
using Client.WebApi.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbcustomerContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IClientService, ClientsService>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolitics", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



#region Peticiones Api Rest
app.MapGet("/Clients/Get", async (
    IClientService _departamentoService,
    IMapper _mapper
    ) =>
{
    var listaClients = await _departamentoService.GetList();
    var ClientsDTO = _mapper.Map<List<ClientsDTO>>(listaClients);

    if (ClientsDTO.Count > 0)
        return Results.Ok(ClientsDTO);
    else
        return Results.NotFound();
});

app.MapGet("/Clients/Get/{idClient}", async (
    int idClient,    
    IClientService _empleadoService,
    IMapper _mapper
    ) =>
{
    var _response = await _empleadoService.Get(idClient);

    if (_response is null) return Results.NotFound();   

    var respuesta = await _empleadoService.Get(idClient);

    return Results.Ok(_mapper.Map<ClientsDTO>(_response));
});

#endregion

app.UseCors("NewPolitics");

app.Run();
