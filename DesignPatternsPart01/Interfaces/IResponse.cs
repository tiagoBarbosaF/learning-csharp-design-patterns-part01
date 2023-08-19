using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Interfaces;

public interface IResponse
{
    void Respond(Requisition requisition, Account account);
}