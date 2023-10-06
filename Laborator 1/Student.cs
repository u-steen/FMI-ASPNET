namespace Laborator_1;

public class Student
{
    public string nume { set; get; }
    public string prenume { set; get; }
    public string cnp { set; get;  }
    public List<Materie> materii { set; get; }

    public string numeComplet()
    {
        return nume.ToUpper() + " " + prenume;
    }

    public void printStudent()
    {
        string materiiStr = "";
        foreach (Materie materie in materii)
        {
            materiiStr += materie.denumire + " ";
        }
       Console.WriteLine("NUME: " + numeComplet() + '\n' + "CNP: " + cnp + "\n" + "Materii: " + materiiStr + '\n');

    }
}