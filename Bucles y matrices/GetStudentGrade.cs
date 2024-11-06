namespace Ejercicio_Creación_de_matrices_y_bucles_foreach;

public class StudentGrade
{
    public static decimal getGrade(int examAssignments, int[] studentScores)
    {
        int sumAssignmentScores = 0;
        int gradedAssignments = 0;

        foreach (int score in studentScores)
        {
            gradedAssignments += 1;

            if (gradedAssignments <= examAssignments)
                sumAssignmentScores += score;

            else
                sumAssignmentScores += score / 10;
        }

        return (decimal)(sumAssignmentScores) / examAssignments;
    }
    
    public static string getLetterGrade(decimal grade)
    {
        string currentStudentLetterGrade;
        if (grade >= 97)
            currentStudentLetterGrade = "A+";
        else if (grade >= 93)
            currentStudentLetterGrade = "A";
        else if (grade >= 90)
            currentStudentLetterGrade = "A-";
        else if (grade >= 87)
            currentStudentLetterGrade = "B+";
        else if (grade >= 83)
            currentStudentLetterGrade = "B";
        else if (grade >= 80)
            currentStudentLetterGrade = "B-";
        else if (grade >= 77)
            currentStudentLetterGrade = "C+";
        else if (grade >= 73)
            currentStudentLetterGrade = "C";
        else if (grade >= 70)
            currentStudentLetterGrade = "C-";
        else if (grade >= 67)
            currentStudentLetterGrade = "D+";
        else if (grade >= 63)
            currentStudentLetterGrade = "D";
        else if (grade >= 60)
            currentStudentLetterGrade = "D-";
        else
            currentStudentLetterGrade = "F";

        return currentStudentLetterGrade;
    }
}