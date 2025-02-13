namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",
                new string[]{"Paris", "Berlin", "london", "Madrid"},
                1
                ),
                new Question("What is 2+2?",
                new string[]{"3", "4", "5", "6"},
                1
                ),
                new Question("Who wrote Hamlet?",
                new string[]{"Goethe", "Austen", "ShakeSpear", "Dickens"},
                2
                )
            };
            Quiz myQuiz = new Quiz(questions);

            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
