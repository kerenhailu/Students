// See https://aka.ms/new-console-template for more information
using Students;

Console.WriteLine("Hello, World!");


List<Lecturer> objectStudent = new List<Lecturer>();
//int[] Array = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };

//שם מרצה
Console.WriteLine("print name of lecturer");
string nameLecturer = Console.ReadLine();

//יצירת סטודנטים
void addStudents()
{
    Console.WriteLine("put number of students");
    int numStudentFromLecturer = int.Parse(Console.ReadLine());

    for (int i = 0; i < numStudentFromLecturer; i++)
    {
        Lecturer studentFromUser = new Lecturer(nameLecturer, Console.ReadLine(), Console.ReadLine(), new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) });
        objectStudent.Add(studentFromUser);

    }
    for (int i = 0; i < objectStudent.Count; i++)
    {
        Console.WriteLine("===========================");
        Console.WriteLine($"{i} :name student {objectStudent[i].nameStudent}, id students{objectStudent[i].idStudent} ," +
            $" grades {objectStudent[i].grades[0]}, {objectStudent[i].grades[1]}, {objectStudent[i].grades[2]} ,{objectStudent[i].name} ,");
        //Console.WriteLine(objectStudent[i].idStudent);
        Console.WriteLine();

    }
}

//יצירת תפריט אופציות
void menu()
{
    Console.WriteLine("choose number 1 for add,number 2 for avrge,number 3 to print the second student, number 4 Search by index");
    int chooseNum = int.Parse(Console.ReadLine());

    switch (chooseNum)
    {
        case 1:
            {
                addStudents();
            }
            break;
        case 2:
            {
                Console.WriteLine("choose name of the students");
                string studentName = Console.ReadLine();
                for (int i = 0; i < objectStudent.Count; i++)
                {
                    Console.WriteLine("===========================");
                    if (objectStudent[i].nameStudent == studentName)
                    {
                        int avrge = objectStudent[i].grades[0] + objectStudent[i].grades[1] + objectStudent[i].grades[2];
                        Console.WriteLine($"avrge : {avrge}");
                    }
                }
                break;
            }
        case 3:
            {
                Console.WriteLine($"1 : name student :{objectStudent[1].nameStudent}, id students:{objectStudent[1].idStudent} ," +
                $" grades :{objectStudent[1].grades[0]}, {objectStudent[1].grades[1]}, {objectStudent[1].grades[2]} ,{objectStudent[1].name} ,");
                break;
            }
        case 4:
            {
                int indexByUser = int.Parse(Console.ReadLine());
                Console.WriteLine($"1 : name student :{objectStudent[indexByUser].nameStudent}, id students:{objectStudent[indexByUser].idStudent} ," +
                $" grades :{objectStudent[indexByUser].grades[0]}, {objectStudent[indexByUser].grades[1]}, {objectStudent[indexByUser].grades[2]} ,{objectStudent[indexByUser].name} ,");
                break;
            }
        default:
            Console.WriteLine("Choose according to the options , try again");
            menu();
            break;
    }
}
menu();


FileStream fileStream = new FileStream($@"C:\Student\{nameLecturer}.txt", FileMode.Append);
using (StreamWriter writer = new StreamWriter(fileStream))
{
    for (int i = 0; i < objectStudent.Count; i++)
    {
        writer.WriteLine($"{i} : name student :{objectStudent[i].nameStudent}, id students:{objectStudent[i].idStudent} ," +
            $" grades :{objectStudent[i].grades[0]}, {objectStudent[i].grades[1]}, {objectStudent[i].grades[2]} ,{objectStudent[i].name} ,");
        Console.WriteLine();
    }
}

List<string> list = new List<string>();
FileStream fileStreamOpen = new FileStream(@"C:\Student\simi.txt", FileMode.Open);

using (StreamReader reader = new StreamReader(fileStreamOpen))
{
    string str = reader.ReadLine();

    list.Add(str);
}

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

//מנגנון שגיאה
try
{
    menu();
}
catch (FormatException)
{
    Console.WriteLine("value must be number");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
