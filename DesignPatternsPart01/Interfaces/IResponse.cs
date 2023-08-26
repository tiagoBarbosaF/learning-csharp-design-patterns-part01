using DesignPatternsPart01.Classes;
using DesignPatternsPart01.Classes.Accounts;

namespace DesignPatternsPart01.Interfaces;

public interface IResponse
{
    void Respond(Requisition requisition, Account account);
}