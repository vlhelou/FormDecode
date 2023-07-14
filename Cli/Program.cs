using System.Text.Json;
using System.Text.Json.Serialization;

string arquivoNome = @"D:\Temporario\saude.sulamericaseguros.com.br2.har";
FileInfo arquivo = new FileInfo(arquivoNome);


string origem = File.ReadAllText(arquivo.FullName);

var har = JsonSerializer.Deserialize<Cli.Dados.Rootobject>(origem);


Console.WriteLine(har.ToString());

using var db = new Cli.Dados.DB();
Cli.Dados.Roteiro roteiro = new Cli.Dados.Roteiro();
roteiro.Nome = arquivo.Name;
db.Add(roteiro);
db.SaveChanges();

foreach (var item in har.log.entries)
{
    Cli.Dados.Requisicao requisicao = new Cli.Dados.Requisicao();
    Console.WriteLine(item.request.url);
    requisicao.IdRoteiro = roteiro.Id;
    requisicao.Url = item.request.url;
    requisicao.Metodo = item.request.method;
    requisicao.Header = JsonSerializer.Serialize(item.request.headers);
    requisicao.Cookie = JsonSerializer.Serialize(item.request.cookies);
    requisicao.Tipo = item._resourceType;
    db.Add(requisicao);
    db.SaveChanges();
}

