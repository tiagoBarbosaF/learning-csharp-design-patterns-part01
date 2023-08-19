namespace DesignPatternsPart01.Classes.Templates;

public abstract class TemplateSimpleReport
{
    public string HeaderSimpleReport(string holder, double balance) => $"Holder: {holder} - Balance: {balance}";
    public string FooterSimpleReport() => "MyBank - Phone: +55 11 3245-5555";
}