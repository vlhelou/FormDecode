using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.CodeAnalysis.CSharp;

namespace DecodForm;

internal static class Decode
{
    public static string DecodeCurl(string origem)
    {
        System.Text.StringBuilder saida = new();
        var linhas = origem.Split("\r\n");

        foreach (var linha in linhas)
        {
            if (linha.Trim().StartsWith("-H"))
            {
                int pontoI = linha.IndexOf("\'");
                if (pontoI == -1)
                    continue;

                int pontoDivisao = linha.IndexOf(":");
                if (pontoDivisao == -1)
                    continue;

                int pontoF = linha.LastIndexOf("\'");
                if (pontoF == -1)
                    continue;
                string chave = linha.Substring(pontoI + 1, pontoDivisao - pontoI - 1).Trim();
                string valor = linha.Substring(pontoDivisao + 1, pontoF - pontoDivisao - 1).Trim().Replace("\"", "\\\""); ;
                if (chave != "Content-Type")
                    saida.AppendLine($"client.DefaultRequestHeaders.Add(\"{chave}\",\"{valor}\");");

            }
            if (linha.Trim().StartsWith("--data-raw"))
            {
                int pontoI = linha.IndexOf("\'");

                int pontoF = linha.LastIndexOf("\'");
                if (pontoF <= pontoI)
                    continue;
                string dadosFormulario = linha.Substring(pontoI + 1, pontoF - pontoI - 1);
                saida.AppendLine("var content = new FormUrlEncodedContent(new[]");
                saida.AppendLine("{");
                saida.AppendLine(DecodeFormUrl(dadosFormulario));
                saida.AppendLine("});");

            }
        }



        return saida.ToString();
    }

    public static string DecodeFormUrl(string origem)
    {
        var campos = origem.Split('&');
        System.Text.StringBuilder saida = new();
        foreach (var campo in campos)
        {
            var chaveValor = campo.Split('=');
            if (chaveValor.Length == 2)
            {

                var chave = SymbolDisplay.FormatLiteral(HttpUtility.UrlDecode(chaveValor[0]), true);
                var valor = SymbolDisplay.FormatLiteral(HttpUtility.UrlDecode(chaveValor[1]), true);

                //string conteudo = $"new KeyValuePair<string, string>(\"{chave}\", \"{valor}\"),";
                

                saida.AppendLine($"new KeyValuePair<string, string>(\"{chave}\", \"{valor}\"),");
            }
        }
        return saida.ToString();

    }

}
