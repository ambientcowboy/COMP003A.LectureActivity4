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
        
        int number = 0;
        while (number <= 6)
        {
            number++;
            //continue is used to skip printing when variable number is equal to 4, skipping to the next iteration within loop body
            if (number == 4)
                continue;
            //break is used to exit the loop when variable number is equal to 6. 
            if (number == 6)
                break;
            Console.WriteLine($"Number {number}");
            
            /*
            Which loop type was easiest for you to understand?
               break and continue were the easiest for me to understand since the conditions are set separately while 
               using the same variable.
            Which loop required the most careful tracing?
               The do-while loop required the most tracing, for myself.
            How did comments help you understand your loops?
                separating loops by comments was helpful to creat clear line and section breaks allowing me to build them out 
                individually with ease.
             */
        }
    }
}