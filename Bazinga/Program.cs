using Bazinga.Data;
using Bazinga.Revisao;
using Microsoft.EntityFrameworkCore;


//teste revisao
//Produto produto1 = new Produto(100, "Calça Jeans", 50);
//Console.WriteLine(produto1.ObterNome());
//Console.WriteLine(produto1.Preco);

//try
//{
//    produto1.AlterarPreco(-50);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//ProdutoDigital produto = new ProdutoDigital(101, "Curso C#", 150);
//Console.WriteLine(produto.Nome);
//Console.WriteLine(produto.Preco);

Produto produto1 = new ProdutoDigital(200, "Curso React", 200);
Produto produto2 = new Produto(205, "Pomada", 15);
Produto produto = new Produto(1, "Teste", 10);
produto1.ExibirTipo();
produto2.ExibirTipo();
produto.ExibirTipo();
//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<BazingaContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("BazingaConnection")
//    ));

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
