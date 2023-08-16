using DesignPatternsPart01.Classes.Enums;

namespace DesignPatternsPart01.Classes;

public class Requisition
{
    public Format Format { get; private set; }

    public Requisition(Format format)
    {
        Format = format;
    }
}