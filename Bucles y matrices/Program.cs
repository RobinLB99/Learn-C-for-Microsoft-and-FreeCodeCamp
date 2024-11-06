// initialize variables - graded assignments 

var currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

static string calculateStudentLetterGrade(decimal studentGrade)
{
    string letterGrade;
    
    if (studentGrade >= 97)
        letterGrade = "A+";

    else if (studentGrade >= 93)
        letterGrade = "A";

    else if (studentGrade >= 90)
        letterGrade = "A-";

    else if (studentGrade >= 87)
        letterGrade = "B+";

    else if (studentGrade >= 83)
        letterGrade = "B";

    else if (studentGrade >= 80)
        letterGrade = "B-";

    else if (studentGrade >= 77)
        letterGrade = "C+";

    else if (studentGrade >= 73)
        letterGrade = "C";

    else if (studentGrade >= 70)
        letterGrade = "C-";

    else if (studentGrade >= 67)
        letterGrade = "D+";

    else if (studentGrade >= 63)
        letterGrade = "D";

    else if (studentGrade >= 60)
        letterGrade = "D-";
    
    else letterGrade = "?";
    
    return letterGrade;
}

Console.WriteLine("Student\t\tGrade\n");

foreach (var name in studentNames)
{
    var currentStudentGrade = (decimal) 0;
    switch (name)
    {
        case "Sophia":
            var sophiaSum = 0;
            foreach (var score in sophiaScores) sophiaSum += score;
            currentStudentGrade = (decimal)sophiaSum / currentAssignments;
            break;

        
        case "Andrew":
            var andrewSum = 0;
            foreach (var score in andrewScores) andrewSum += score;
            currentStudentGrade = (decimal)andrewSum / currentAssignments;
            break;

        case "Emma":
            var emmaSum = 0;
            foreach (var score in emmaScores) emmaSum += score;
            currentStudentGrade = (decimal)emmaSum / currentAssignments;
            break;

        case "Logan":
            var loganSum = 0;
            foreach (var score in loganScores) loganSum += score;
            currentStudentGrade = (decimal)loganSum / currentAssignments;
            break;

        default:
            Console.WriteLine("Nombre de estudiante no encontrado!");
            break;
    }

    var currentStudentLetterGrade = calculateStudentLetterGrade(currentStudentGrade);

    Console.WriteLine($"{name}:\t\t" + currentStudentGrade + $"\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();