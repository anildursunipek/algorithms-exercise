namespace Homework
{
    class Test
    {
        public static void Main(string[] args)
        {
            string name, surname;
            int age, boardCount;
            bool abonman = false;
            User user;
            while (true) {
                Console.WriteLine("Please Enter The Name(Enter 'exit' for exit)");
                name = Console.ReadLine();
                if(name == "exit")
                {
                    break;
                }
                Console.WriteLine("Please Enter The Surname");
                surname = Console.ReadLine();
                Console.WriteLine("Please Enter The Age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Penter the total number of bus rides.");
                boardCount = Convert.ToInt32(Console.ReadLine());
                if(age > 65)
                {
                    user = new OlderThan65(name, surname , age);
                }
                else
                {
                    Console.WriteLine("Please Select The Card Type \n1- Normal\n2-Teacher\n3-Student\n4-Free User");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            user = new NormalUser(name, surname, age);
                            break;
                        case 2:
                            user = new Teacher(name, surname, age);
                            break;
                        case 3:
                            user = new Student(name, surname, age);
                            break;
                        case 4:
                            user = new FreeUser(name, surname, age);
                            break;
                        default:
                            Console.WriteLine("Incorrect entry made. It will be calculated as Normal User. ");
                            user = new NormalUser(name, surname, age);
                            break;
                    }
                    Console.WriteLine("Do you have a Abonman(Subscription)?(Please enter 'y' -> yes or 'n' -> no");
                
                    switch (Console.ReadKey().KeyChar)
                    {
                        case 'y':
                            abonman = true;
                            break;
                        case 'n':
                            abonman = false;
                            break;
                    }
                }
                BaseCard card = new BaseCard(user, boardCount, abonman);
                Console.WriteLine("\nTotal Cost: " + card.CalculateTotalCost());
            }
        }
    }

    class BaseCard
    {
        User _user;
        int _boardCount;
        private bool _abonman;

        public BaseCard(User user, int boardCount, bool Abonman)
        {
            _user = user;
            _boardCount = boardCount;
            _abonman = Abonman;
            if(Abonman == true)
            {
                _user.FreePass = 160;
            }
        }
        public int BoardCount { get => _boardCount; set => _boardCount = value; }
        public bool Abonman { get => _abonman; set => _abonman = value; }

        public double CalculateTotalCost()
        {
            if(_user.FreePass > 0)
            {
                _user.FreePass -= _boardCount;
                if(_user.FreePass < 0)
                {
                    return (-1 * (_user.FreePass * _user.Cost)) + _user.AbonmanCost;
                }
                return _user.AbonmanCost;
            }
            return _user.Cost * _boardCount;
        }
    }
    class User
    {
        private string _name;
        private string _surname;
        private int _age;
        private double _cost;
        private int _freePass;
        private int _abonmanCost;

        public User(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public int Age { get => _age; set => _age = value; }
        public double Cost { get => _cost; set => _cost = value; }
        public int FreePass { get => _freePass; set => _freePass = value; }
        public int AbonmanCost { get => _abonmanCost; set => _abonmanCost = value; }
    }

    class NormalUser : User
    {
        public NormalUser(string name, string surname, int age) : base(name, surname, age)
        {
            Cost = 7.5;
            FreePass = 0;
            AbonmanCost = 375;
        }
    }
    class Teacher : User {
    
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {
            Cost = 7;
            FreePass = 0;
            AbonmanCost = 375;
        }
    }
    class Student : User
    {
        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            Cost = 3.75;
            FreePass = 0;
            AbonmanCost = 90;
        }
    }
    class OlderThan65 : User
    {
        public OlderThan65(string name, string surname, int age) : base(name, surname, age)
        {
            Cost = 7.5;
            FreePass = 160;
            AbonmanCost = 0;
        }
    }
    class FreeUser : User
    {

        public FreeUser(string name, string surname, int age) : base(name, surname, age)
        {
            Cost = 5;
            FreePass = 160;
            AbonmanCost = 0;
        }
    }
}