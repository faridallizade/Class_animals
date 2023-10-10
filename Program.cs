namespace Class_animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal("Poodle" ,"Hero", -1);
            dog.GetInfo();
            Cat cat = new Cat("British ShortHair" ,"Smoke", 2);
            cat.GetInfo();
            Snake snake = new Snake("Phyton", "Saleh", 19,false);
            snake.GetInfo();
            Dolphin dolphin = new Dolphin("Blue" ,"Mr.Moustache", 7);
            dolphin.GetInfo();
            
        }
    }
}