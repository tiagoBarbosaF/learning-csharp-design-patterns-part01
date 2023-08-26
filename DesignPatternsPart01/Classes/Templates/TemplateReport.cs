using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Classes.Templates;

public abstract class TemplateReport
{
    protected abstract void Header();
    protected abstract void Footer();
    protected abstract void Body(IEnumerable<Account> accounts);

    public void Print(IEnumerable<Account> accounts)
    {
        Header();
        Body(accounts);
        Footer();
    }
}