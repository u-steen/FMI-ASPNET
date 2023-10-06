namespace Laborator_1;


public class Materie
{
    public string denumire { set; get; }
    public int durata { set; get; }

    public string getMaterie()
    {
        return denumire + " | " + durata + "minute";
    }
}