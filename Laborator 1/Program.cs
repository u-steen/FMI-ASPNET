using Laborator_1;

void printStudenti(List<Student> studenti)
{
    foreach (Student student in studenti)
    {
        student.printStudent();
    }
}

    // initializare materii
// Matematica
Materie matematica = new Materie();
matematica.denumire = "Matematica";
matematica.durata = 90;
// Programare
Materie prog = new Materie();
prog.denumire = "Programare";
prog.durata = 120;
// Sport
Materie sport = new Materie();
sport.denumire = "Educatie fizica";
sport.durata = 45;
// Engleza
Materie engleza = new Materie();
engleza.denumire = "Engleza";
engleza.durata = 60;
// Istorie
Materie istorie = new Materie();
istorie.denumire = "Istorie";
istorie.durata = 100;

    // Initializare studenti
List<Student> studenti = new List<Student>();
// student 1
Student student1 = new Student();
student1.prenume = "Ion";
student1.nume = "Popescu";
student1.cnp = "5061001551102";
student1.materii = new List<Materie> { matematica, prog, sport, istorie };
studenti.Add(student1);

// student 2
Student student2 = new Student();
student2.prenume = "Radu";
student2.nume = "Vasile";
student2.cnp = "74320984239";
student2.materii = new List<Materie> { matematica, prog};
studenti.Add(student2);

// printStudent
printStudenti(studenti);