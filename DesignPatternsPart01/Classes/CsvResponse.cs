using DesignPatternsPart01.Classes.Accounts;
using DesignPatternsPart01.Classes.Enums;
using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class CsvResponse : IResponse
{
    public IResponse AnotherResponse { get; private set; }

    public CsvResponse(IResponse anotherResponse)
    {
        AnotherResponse = anotherResponse;
    }

    public CsvResponse()
    {
        AnotherResponse = null;
    }

    public void Respond(Requisition requisition, Account account)
    {
        if (requisition.Format == Format.Csv)
        {
            Console.WriteLine($"{account.Holder};{account.Balance}");
        }
        else if (AnotherResponse != null)
        {
            AnotherResponse.Respond(requisition, account);
        }
        else
        {
            throw new Exception("Format not founded.");
        }
    }
}