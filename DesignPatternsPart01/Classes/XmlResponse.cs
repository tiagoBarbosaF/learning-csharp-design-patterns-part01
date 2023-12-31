﻿using DesignPatternsPart01.Classes.Accounts;
using DesignPatternsPart01.Classes.Enums;
using DesignPatternsPart01.Interfaces;

namespace DesignPatternsPart01.Classes;

public class XmlResponse : IResponse
{
    public IResponse AnotherResponse { get; private set; }

    public XmlResponse(IResponse anotherResponse)
    {
        AnotherResponse = anotherResponse;
    }

    public XmlResponse()
    {
        AnotherResponse = null;
    }

    public void Respond(Requisition requisition, Account account)
    {
        if (requisition.Format == Format.Xml)
        {
            Console.WriteLine(
                $"<account><holder>{account.Holder}</holder><balance>{account.Balance}</balance></account>");
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