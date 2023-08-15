using DesignPatternsPart01;
using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Enums;
using DesignPatternsPart01.Classes.Taxes;

internal class Program
{
    public static void Main(string[] args)
    {
        // var icms = new ICMS();
        // var iss = new ISS();


// calculator.PerformsCalculation(icms.GetType().Name, budget, icms);
// calculator.PerformsCalculation(iss.GetType().Name, budget, iss);


        // var iccc = new ICCC();
        // var budget1 = new Budget(500);
        // var budget2 = new Budget(2300);
        // var budget3 = new Budget(3800);
        //
        // var calculator = new TaxesCalculator();
        //
        // calculator.PerformsCalculation(iccc.GetType().Name, budget1, iccc);
        // calculator.PerformsCalculation(iccc.GetType().Name, budget2, iccc);
        // calculator.PerformsCalculation(iccc.GetType().Name, budget3, iccc);
        // Console.WriteLine("---");
        // iccc.PerformsCalculation(iccc.GetType().Name, budget1, iccc);

        var investment = new MakeInvestment();
        var account = new Account();
        var moderate = new Moderate();
        var conservative = new Conservative();
        var bold = new Bold();

        account.Deposit(1000);
        
        investment.Investment(account, moderate);
        investment.Investment(account, conservative);
        investment.Investment(account, bold);
    }
}