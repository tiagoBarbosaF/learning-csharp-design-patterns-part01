using System.ComponentModel.Design;
using DesignPatternsPart01.Classes.Accounts;
using DesignPatternsPart01.Classes.Enums;
using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class PercentResponse : IResponse
{
    public IResponse AnotherResponse { get; private set; }

    public PercentResponse(IResponse anotherResponse)
    {
        AnotherResponse = anotherResponse;
    }

    public PercentResponse()
    {
        AnotherResponse = null;
    }

    public void Respond(Requisition requisition, Account account)
    {
        if (requisition.Format == Format.Percent)
        {
            Console.WriteLine($"{account.Holder}%{account.Balance}");
        }
        else if (AnotherResponse != null)
        {
            AnotherResponse.Respond(requisition, account);
        }
        else
        {
            throw new Exception("Format not finded.");
        }
    }
}