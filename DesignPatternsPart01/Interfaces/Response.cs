using DesignPatternsPart01.Classes;

namespace DesignPatternsPart01.Interfaces;

public interface Response
{
    void Respond(Requisition requisition, Account account);
}