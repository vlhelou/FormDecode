namespace DecodForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Transforma_Click(object sender, EventArgs e)
    {
        var lnOrigem = origem.Text.Split("\r\n");
        var linhas = lnOrigem.Where(p => !string.IsNullOrEmpty(p)).ToList();
        if (linhas.Count > 0)
        {
            var linha = linhas.First().Trim();
            if (linha.ToLower().StartsWith("curl"))
            {
                Destino.Text = Decode.DecodeCurl(origem.Text);
            }
            else
            {
                Destino.Text = Decode.DecodeFormUrl(origem.Text);

            }
            System.Windows.Forms.Clipboard.SetText(Destino.Text);
        }

    }
}