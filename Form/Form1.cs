namespace DecodForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        origem.Text = """
            curl 'https://saude.sulamericaseguros.com.br/prestador/login/' \
            -H 'authority: saude.sulamericaseguros.com.br' \
            -H 'accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7' \
            -H 'accept-language: pt-BR,pt;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6' \
            -H 'cache-control: max-age=0' \
            -H 'content-type: application/x-www-form-urlencoded' \
            -H 'cookie: __nomep=; lumUserLocale=pt_BR; lumClientId=8A61648F894C6DBF01894F14B59E0D46; _fbp=fb.2.1689254130040.698625270; dtCookie=v_4_srv_12_sn_108B43D41D13B40BFA5E5CF50356B22A_perc_100000_ol_0_mul_1_app-3A1cdd41f914150495_1_app-3Af21c02af711eb9d5_1_app-3A1fcdae72075d44d9_1_rcs-3Acss_0; tel=central_atendimento_doctorline.gif; rxVisitor=1689097827264A95PLDHVBSP6U9V67QG2L8N469B9H72P; __app=prestador; __site=sulamerica-saude; __page=Home | SulAmerica; __codp=006109800001; _gid=GA1.3.2027797670.1689254142; __utmc=11233718; __utmz=11233718.1689254142.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); ln_or=eyIyMjI2NjUiOiJkIn0%3D; _hjSessionUser_1955131=eyJpZCI6ImFhYjViNmZjLWUyMjEtNWExMS05ZmFmLWY4NGFjNWI1ZTY5OCIsImNyZWF0ZWQiOjE2ODkyNTQxNDE3NzMsImV4aXN0aW5nIjp0cnVlfQ==; boxLgpdAcceptedCookie=true; _ga_3HQMVENFZW=GS1.1.1689265809.11.0.1689265809.0.0.0; _ga_0KDYZPF8ZT=GS1.1.1689265809.11.0.1689265809.0.0.0; __cf_bm=w5zAd1rk.Phv.0XR4myVrCXEJ26_m9WU9KsThpZRCyA-1689334635-0-ARVRM4FsnlGjcS6saSuGfVyFfw9Xn8nLQrOS0ssVaKJfuhOCXoonOB6kEOtZvSP6786defkprbACOMxaCQFtz90=; _hjIncludedInSessionSample_1955131=0; _hjSession_1955131=eyJpZCI6IjM2OWYyNTAyLTM3YzMtNDhhYS04M2ZhLTA0NTA2NDk1M2NkYyIsImNyZWF0ZWQiOjE2ODkzMzQ2NDk2NjYsImluU2FtcGxlIjpmYWxzZX0=; JSESSIONID=s01jbs158~fVXc3TEXPfgmDZUIYlz668EP_iLWRUpL2MLJJjGi.s01jbs158; lumIsLoggedUser=true; lumUserId=8A6164AA60470BB20160558BCA8C48C4; lumUserSessionId=7aZukHamfJaKnBZvOOlg-QjXm25Qu66t; __utma=11233718.2098824336.1689254141.1689259345.1689334686.3; __utmb=11233718.1.10.1689334686; _ga=GA1.1.2098824336.1689254141; _ga_GT8PCDTCXZ=GS1.3.1689334649.3.1.1689335388.60.0.0; rxvt=1689337188939|1689334648852; dtPC=12$335388338_2h-vBMFUDCTFFGPRDCEKBKJUKCOBRTAUFIRI-0e0; _ga_HEWHCZNGK0=GS1.1.1689334649.4.1.1689335648.0.0.0; _ga_M3S5VMZ7VB=GS1.1.1689334649.12.1.1689335648.0.0.0; _ga_8MDSH1YG45=GS1.1.1689334649.1.1.1689335648.0.0.0; _ga_YZ8V1YKTQR=GS1.1.1689334649.12.1.1689335648.0.0.0; _ga_XDNXH4S93Y=GS1.1.1689334655.5.1.1689335648.60.0.0; dtSa=true%7CC%7C-1%7CEntrar%7C-%7C1689335648196%7C335388338_2%7Chttps%3A%2F%2Fsaude.sulamericaseguros.com.br%2Fprestador%2Flogin%2F%7C%7C%7C%7C; ADRUM=s=1689335648296&r=https%3A%2F%2Fsaude.sulamericaseguros.com.br%2Fprestador%2Flogin%2F%3F0' \
            -H 'dnt: 1' \
            -H 'origin: https://saude.sulamericaseguros.com.br' \
            -H 'referer: https://saude.sulamericaseguros.com.br/prestador/login/' \
            -H 'sec-ch-ua: "Not.A/Brand";v="8", "Chromium";v="114", "Microsoft Edge";v="114"' \
            -H 'sec-ch-ua-mobile: ?0' \
            -H 'sec-ch-ua-platform: "Windows"' \
            -H 'sec-fetch-dest: document' \
            -H 'sec-fetch-mode: navigate' \
            -H 'sec-fetch-site: same-origin' \
            -H 'sec-fetch-user: ?1' \
            -H 'upgrade-insecure-requests: 1' \
            -H 'user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.79' \
            --data-raw 'lumNewParams=%3Cparameters+destId%3D%228A61890A697C8A4C01697C9D3DE0250E%22+destType%3D%22lumII%22%3E%3Cp+n%3D%22lumFromForm%22%3EForm_8A61890A697C8A4C01697C9D3DE0250E%3C%2Fp%3E%3Cp+n%3D%22lumFormAction%22%3Ehttps%3A%2F%2Fsaude.sulamericaseguros.com.br%2Fmain.jsp%3FlumPageId%3D8A61898253CE1C780153D20B7FF82329%26amp%3BlumA%3D1%26amp%3BlumII%3D8A61890A697C8A4C01697C9D3DE0250E%3C%2Fp%3E%3Cp+n%3D%22doui_processActionId%22%3EloginPrestador%3C%2Fp%3E%3Cp+n%3D%22doui_fromForm%22%3EForm_8A61890A697C8A4C01697C9D3DE0250E%3C%2Fp%3E%3Cp+n%3D%22lumII%22%3E8A61890A697C8A4C01697C9D3DE0250E%3C%2Fp%3E%3Cp+n%3D%22code%22%3E006109800001%3C%2Fp%3E%3Cp+n%3D%22user%22%3Emaster%3C%2Fp%3E%3Cp+n%3D%22senha%22%3Ehsm%401599%3C%2Fp%3E%3C%2Fparameters%3E&lumPrinting=&lumToggleModeOriginUrl=&lumSafeRenderMode=&lumPageOriginalUrl=main.jsp%3FlumPageId%3D8A61898253CE1C780153D20B7FF82329&lumS=&lumSI=&lumI=&lumII=8A61890A697C8A4C01697C9D3DE0250E&lumReplIntfState=&lumPrevParams=%253CallParameters%253E%253Cparameters%253E%253Cp%2Bn%253D%2522lumChannelId%2522%253E8A488A8E2849180101285A25D21C299E%253C%252Fp%253E%253C%252Fparameters%253E%253C%252FallParameters%253E&lumA=1&lumDataPreviewMode=&lumClientMessage=' \
            --compressed
            """;
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