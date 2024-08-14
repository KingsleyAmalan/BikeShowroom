using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
#region DBContext
builder.Services.AddDbContext<DBContext>(opt=>{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#endregion

var app = builder.Build();



app.MapControllers();

app.Run();
