using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli.Dados;

internal record Requisicao
{
    public int Id { get; set; }
    public int IdRoteiro { get; set; }
    public string Url { get; set; } = string.Empty;
    public string  Metodo { get; set; } = string.Empty;
    public string? Header { get; set; }
    public string? Cookie { get; set; }

    [ForeignKey(nameof(IdRoteiro))]
    public Roteiro Roteiro { get; set; } = new Roteiro();
}
