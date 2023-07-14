using System.ComponentModel.DataAnnotations.Schema;

namespace Cli.Dados;

[Table("Roteiro")]
internal record Roteiro
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}
