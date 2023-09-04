using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp;

namespace DecodForm;

internal static class Decode
{
    public static string DecodeCurl(string origem)
    {
        System.Text.StringBuilder saida = new();
        var linhas = origem.Split("\r\n");
        string cookies = string.Empty;

        foreach (string linha in linhas)
        {
            if (linha.Trim().StartsWith("-H 'cookie:"))
            {
                cookies = Decode.TransformaCookie(linha.Trim());
            }
            else if (linha.Trim().StartsWith("-H 'content-type:"))
            {
                continue;
            }
            else if (linha.Trim().StartsWith("-H"))
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
            else if (linha.Trim().StartsWith("--data-raw"))
            {
                int pontoI = linha.IndexOf("\'");

                int pontoF = linha.LastIndexOf("\'");
                if (pontoF <= pontoI)
                    continue;
                string dadosFormulario = linha.Substring(pontoI + 1, pontoF - pontoI - 1);
                saida.AppendLine("List<KeyValuePair<string, string>> FormValores = new List<KeyValuePair<string, string>>();");
                //saida.AppendLine("var content = new FormUrlEncodedContent(new[]");
                //saida.AppendLine("{");
                saida.AppendLine(DecodeFormUrl(dadosFormulario));
                //saida.AppendLine("});");
                saida.AppendLine("var content = new FormUrlEncodedContent(FormValores);");

            }
        }
        if (!string.IsNullOrEmpty(cookies))
            saida.AppendLine(cookies);



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
                
                saida.AppendLine($"FormValores.Add(new KeyValuePair<string, string>({chave}, {valor}));");
            }
        }
        return saida.ToString();

    }

    public  static string TransformaCookie(string origem)
    {
        System.Text.StringBuilder retorno = new();
        int ponto1 = origem.IndexOf("'cookie:");
        if (ponto1 == -1)
            return string.Empty;
        int ponto2 = origem.LastIndexOf("\'");
        if (ponto2==-1)
            return string.Empty;

        string[] pares = origem.Substring(ponto1 + 9, ponto2 - ponto1 - 9).Split(";");
        foreach(string par in pares)
        {
            Console.WriteLine(par);
            if (par.IndexOf("=") != -1)
            {
                string nome = WebUtility.UrlDecode( par.Split("=").First().Trim());
                string valor = WebUtility.UrlDecode( par.Split("=").Last().Trim());
                retorno.AppendLine($$"""cookieContainer.Add(new Cookie() { Name = "{{nome}}", Value = "{{valor}}", Domain= "dominio.com.br" }); """);
            }
        }

        return retorno.ToString();
    }

}
