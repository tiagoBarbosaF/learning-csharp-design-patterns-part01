namespace DesignPatternsPart01.Classes.Templates;

public abstract class TemplateComplexReport
{
    public string HeaderComplexReport(string holder, string agency, string number, double balance) =>
        $"Holder: {holder} - Agency: {agency} - Number: {number} - Balance: {balance}";
    public string FooterComplexRepost() => "MyBank - Phone: +55 11 3245-5555";
}