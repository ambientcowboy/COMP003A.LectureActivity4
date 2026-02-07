namespace COMP003A.LectureActivity4;

class Program
{
    static void Main(string[] args)
    {
        int taskNumber = 1;
        //this loop displays/prints a message for task number inputs 1-5
        while (taskNumber <= 5) 
        {
            Console.WriteLine($"Task {taskNumber} completed");
            taskNumber++;
        }

        int attempt = 1;
        /*
         this do-while loop checks the set condition after the program runs the loop body at lease once,
         this ensures that the code within the loop body executes at least once.
         This execution occurs even if the condition set is initially false.
         */
        do 
        {
            Console.WriteLine($"Attempt {attempt}");
            attempt++;
        } while (attempt <= 3);

        //We use a for loop for this task because we know the number of iterations before programming the loop.
        for (int step = 1; step <= 4; step++)
        {
            Console.WriteLine($"Step {step}");
        }
    }
}