

namespace Homework3
{


    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please select a sorting algorithm");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");

            string? userSelection = Console.ReadLine();

            Student student1 = new Student("Melissa", 4.0);
            Student student2 = new Student("Rich", 3.0);
            Student student3 = new Student("Adam", 3.8);
            Student student4 = new Student("Madeline", 3.9);
            Student student5 = new Student("Kevin", 2.4);

            Student[] students = { student1, student2, student3, student4, student5 };


            switch (userSelection)
            {
                case "1":
                    // Bubble Sort
                    BubbleSort(students);
                    Console.Write("Bubble Sort: ");
                    PrintArray(students);
                    break;


                case "2":

                    // Selection Sort
                    SelectionSort(students);
                    Console.Write("Selection Sort: ");
                    PrintArray(students);
                    break;


                case "3":

                    // Insertion Sort
                    InsertionSort(students);
                    Console.Write("Insertion Sort: ");
                    PrintArray(students);
                    break;


                default:
                    break;
            }

        }

        public static void PrintArray(Student[] arr)
        {

            foreach (var item in arr)

            {

                Console.Write($"{item.name}: {item.gpa}");

            }

            Console.WriteLine();

        }

        public static void BubbleSort(Student[] arrToSort)
        {

            Student temp;

            
            for (int i = 0; i < arrToSort.Length; i++)
            {
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)

                {
                    // we need to swap
                    if (arrToSort[j].gpa > arrToSort[j + 1].gpa)
                    {
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }

            }

        }

        public static void SelectionSort(Student[] arrToSort)
        {
            int n = arrToSort.Length; // Gets the length of the array

            // Iterates through all except last element
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; // current index is minimum

                // Checks remaining unsorted elements
                for (int j = i + 1; j < n; j ++)
                {
                    //Compares gpa values to find smalles gpa
                    if (arrToSort[j].gpa < arrToSort[minIndex].GPA)
                    {
                        minIndexIndex = j; //minIndex is yodated
                    }
                }
            }

            if (minIndex != i)
            {
                Student temp = arrToSort[i]; 
                arrToSort[i] = arrToSort[minIndex]; 
                arrToSort[minIndex] = temp; 
            }

        }
        public static void InsertionSort(Student[] arrToSort)
        {

            int n = arrToSort.Length; // Receives the length of the array


            for (int i = 1; i < n; i++)
            {
                Student key = arrToSort[i];
                int j = i - 1;

                // Move all elements of arrToSort[], that are greater than the key, to the position that is ahead.
                while (j >= 0 && arrToSort[j].GPA > key.GPA)
                {
                    arrToSort[j + 1] = arrToSort[j]; // Shifts element right
                    j--;
                }
                arrToSort[j + 1] = key;
            }
        }
    }
}