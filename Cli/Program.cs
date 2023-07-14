using System.Text.Json;
using System.Text.Json.Serialization;

string arquivoNome = @"d:\temporario\teste.har";
FileInfo arquivo = new FileInfo(arquivoNome);


string origem = File.ReadAllText(arquivo.FullName);

var har = JsonSerializer.Deserialize<Cli.Dados.Rootobject>(origem);


Console.WriteLine(har.ToString());

using var db = new Cli.Dados.DB();
Cli.Dados.Roteiro roteiro = new Cli.Dados.Roteiro();
roteiro.Nome = "Teste";
db.Add(roteiro);
db.SaveChanges();

