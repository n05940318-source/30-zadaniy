using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("       C# ООП — 30 ЗАДАНИЙ");
            Console.WriteLine("======================================");
            Console.WriteLine(" 1. Животное");
            Console.WriteLine(" 2. Транспорт");
            Console.WriteLine(" 3. Человек и студент");
            Console.WriteLine(" 4. Сотрудники");
            Console.WriteLine(" 5. Фигуры");
            Console.WriteLine(" 6. Транспорт с методом движения");
            Console.WriteLine(" 7. Работник магазина");
            Console.WriteLine(" 8. Компьютеры");
            Console.WriteLine(" 9. Книги");
            Console.WriteLine("10. Домашние животные");
            Console.WriteLine("11. Банковские счета");
            Console.WriteLine("12. Транспортная компания");
            Console.WriteLine("13. Работники компании");
            Console.WriteLine("14. Система образования");
            Console.WriteLine("15. Военная техника");
            Console.WriteLine("16. Игровые персонажи");
            Console.WriteLine("17. Электронные устройства");
            Console.WriteLine("18. Платежи");
            Console.WriteLine("19. Сотрудники с бонусами");
            Console.WriteLine("20. Животные зоопарка");
            Console.WriteLine("21. Абстрактные фигуры");
            Console.WriteLine("22. Интернет-магазин");
            Console.WriteLine("23. Система транспорта");
            Console.WriteLine("24. Больница");
            Console.WriteLine("25. Система сотрудников");
            Console.WriteLine("26. Игра: персонажи");
            Console.WriteLine("27. Файлы");
            Console.WriteLine("28. Система оплаты зарплаты");
            Console.WriteLine("29. Полиморфизм + наследование");
            Console.WriteLine("30. Итоговое задание — автопарк");
            Console.WriteLine(" 0. Выход");
            Console.WriteLine("======================================");

            Console.Write("Введите номер задания: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Введите число.");
                Pause();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                case 3: Task3(); break;
                case 4: Task4(); break;
                case 5: Task5(); break;
                case 6: Task6(); break;
                case 7: Task7(); break;
                case 8: Task8(); break;
                case 9: Task9(); break;
                case 10: Task10(); break;
                case 11: Task11(); break;
                case 12: Task12(); break;
                case 13: Task13(); break;
                case 14: Task14(); break;
                case 15: Task15(); break;
                case 16: Task16(); break;
                case 17: Task17(); break;
                case 18: Task18(); break;
                case 19: Task19(); break;
                case 20: Task20(); break;
                case 21: Task21(); break;
                case 22: Task22(); break;
                case 23: Task23(); break;
                case 24: Task24(); break;
                case 25: Task25(); break;
                case 26: Task26(); break;
                case 27: Task27(); break;
                case 28: Task28(); break;
                case 29: Task29(); break;
                case 30: Task30(); break;

                case 0:
                    Console.WriteLine("Программа завершена.");
                    return;

                default:
                    Console.WriteLine("Такого задания нет.");
                    Pause();
                    continue;
            }

            Pause();
        }
    }

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Нажмите Enter для возврата в меню...");
        Console.ReadLine();
    }

    // ============================================================
    // ЗАДАНИЕ 1
    // ============================================================

    static void Task1()
    {
        Console.WriteLine("ЗАДАНИЕ 1 — ЖИВОТНОЕ");
        Console.WriteLine();

        T1Animal dog = new T1Dog();
        T1Animal cat = new T1Cat();

        dog.Speak();
        cat.Speak();
    }

    class T1Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Животное издает звук.");
        }
    }

    class T1Dog : T1Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Собака: Гав-гав!");
        }
    }

    class T1Cat : T1Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Кошка: Мяу!");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 2
    // ============================================================

    static void Task2()
    {
        Console.WriteLine("ЗАДАНИЕ 2 — ТРАНСПОРТ");
        Console.WriteLine();

        T2Car car = new T2Car
        {
            Brand = "Toyota",
            Speed = 180,
            Doors = 4
        };

        T2Motorcycle motorcycle = new T2Motorcycle
        {
            Brand = "Honda",
            Speed = 220,
            EngineVolume = 600
        };

        Console.WriteLine($"Автомобиль: {car.Brand}");
        Console.WriteLine($"Скорость: {car.Speed} км/ч");
        Console.WriteLine($"Количество дверей: {car.Doors}");

        Console.WriteLine();

        Console.WriteLine($"Мотоцикл: {motorcycle.Brand}");
        Console.WriteLine($"Скорость: {motorcycle.Speed} км/ч");
        Console.WriteLine($"Объем двигателя: {motorcycle.EngineVolume} см³");
    }

    class T2Vehicle
    {
        public string Brand;
        public double Speed;
    }

    class T2Car : T2Vehicle
    {
        public int Doors;
    }

    class T2Motorcycle : T2Vehicle
    {
        public int EngineVolume;
    }

    // ============================================================
    // ЗАДАНИЕ 3
    // ============================================================

    static void Task3()
    {
        Console.WriteLine("ЗАДАНИЕ 3 — ЧЕЛОВЕК И СТУДЕНТ");
        Console.WriteLine();

        T3Student student = new T3Student
        {
            Name = "Абай",
            Age = 16,
            Specialty = "Программирование",
            Course = 1
        };

        student.ShowInfo();
    }

    class T3Person
    {
        public string Name;
        public int Age;
    }

    class T3Student : T3Person
    {
        public string Specialty;
        public int Course;

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Специальность: {Specialty}");
            Console.WriteLine($"Курс: {Course}");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 4
    // ============================================================

    static void Task4()
    {
        Console.WriteLine("ЗАДАНИЕ 4 — СОТРУДНИКИ");
        Console.WriteLine();

        T4Manager manager = new T4Manager
        {
            Name = "Иван",
            Salary = 500000,
            TeamSize = 10
        };

        T4Developer developer = new T4Developer
        {
            Name = "Алексей",
            Salary = 600000,
            ProgrammingLanguage = "C#"
        };

        Console.WriteLine(
            $"Менеджер: {manager.Name}, " +
            $"зарплата: {manager.Salary}, " +
            $"команда: {manager.TeamSize} человек");

        Console.WriteLine(
            $"Разработчик: {developer.Name}, " +
            $"зарплата: {developer.Salary}, " +
            $"язык: {developer.ProgrammingLanguage}");
    }

    class T4Employee
    {
        public string Name;
        public double Salary;
    }

    class T4Manager : T4Employee
    {
        public int TeamSize;
    }

    class T4Developer : T4Employee
    {
        public string ProgrammingLanguage;
    }

    // ============================================================
    // ЗАДАНИЕ 5
    // ============================================================

    static void Task5()
    {
        Console.WriteLine("ЗАДАНИЕ 5 — ФИГУРЫ");
        Console.WriteLine();

        T5Shape rectangle = new T5Rectangle
        {
            Width = 5,
            Height = 4
        };

        T5Shape circle = new T5Circle
        {
            Radius = 3
        };

        Console.WriteLine(
            $"Площадь прямоугольника: {rectangle.GetArea():F2}");

        Console.WriteLine(
            $"Площадь круга: {circle.GetArea():F2}");
    }

    class T5Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }

    class T5Rectangle : T5Shape
    {
        public double Width;
        public double Height;

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class T5Circle : T5Shape
    {
        public double Radius;

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 6
    // ============================================================

    static void Task6()
    {
        Console.WriteLine("ЗАДАНИЕ 6 — ТРАНСПОРТ С МЕТОДОМ ДВИЖЕНИЯ");
        Console.WriteLine();

        List<T6Vehicle> vehicles = new List<T6Vehicle>
        {
            new T6Car(),
            new T6Bus(),
            new T6Train()
        };

        foreach (T6Vehicle vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    class T6Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Транспорт движется.");
        }
    }

    class T6Car : T6Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль едет по дороге.");
        }
    }

    class T6Bus : T6Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Автобус перевозит пассажиров.");
        }
    }

    class T6Train : T6Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Поезд движется по рельсам.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 7
    // ============================================================

    static void Task7()
    {
        Console.WriteLine("ЗАДАНИЕ 7 — РАБОТНИК МАГАЗИНА");
        Console.WriteLine();

        T7Worker cashier = new T7Cashier
        {
            Name = "Анна",
            Position = "Кассир"
        };

        T7Worker seller = new T7Seller
        {
            Name = "Максим",
            Position = "Продавец"
        };

        cashier.Work();
        seller.Work();
    }

    class T7Worker
    {
        public string Name;
        public string Position;

        public virtual void Work()
        {
            Console.WriteLine($"{Name} работает.");
        }
    }

    class T7Cashier : T7Worker
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} работает кассиром.");
        }
    }

    class T7Seller : T7Worker
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} работает продавцом.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 8
    // ============================================================

    static void Task8()
    {
        Console.WriteLine("ЗАДАНИЕ 8 — КОМПЬЮТЕРЫ");
        Console.WriteLine();

        T8Laptop laptop = new T8Laptop
        {
            Processor = "Intel Core i5",
            RAM = 16,
            ScreenSize = 15.6
        };

        T8Desktop desktop = new T8Desktop
        {
            Processor = "AMD Ryzen 7",
            RAM = 32,
            HasRGB = true
        };

        Console.WriteLine(
            $"Ноутбук: {laptop.Processor}, " +
            $"RAM: {laptop.RAM} ГБ, " +
            $"экран: {laptop.ScreenSize}\"");

        Console.WriteLine();

        Console.WriteLine(
            $"ПК: {desktop.Processor}, " +
            $"RAM: {desktop.RAM} ГБ, " +
            $"RGB: {desktop.HasRGB}");
    }

    class T8Computer
    {
        public string Processor;
        public int RAM;
    }

    class T8Laptop : T8Computer
    {
        public double ScreenSize;
    }

    class T8Desktop : T8Computer
    {
        public bool HasRGB;
    }

    // ============================================================
    // ЗАДАНИЕ 9
    // ============================================================

    static void Task9()
    {
        Console.WriteLine("ЗАДАНИЕ 9 — КНИГИ");
        Console.WriteLine();

        T9PaperBook paperBook = new T9PaperBook
        {
            Title = "Война и мир",
            Author = "Лев Толстой",
            Pages = 1200
        };

        T9EBook ebook = new T9EBook
        {
            Title = "C# для начинающих",
            Author = "Иван Иванов",
            FileSize = 5.5
        };

        Console.WriteLine(
            $"{paperBook.Title} — {paperBook.Author}, " +
            $"страниц: {paperBook.Pages}");

        Console.WriteLine(
            $"{ebook.Title} — {ebook.Author}, " +
            $"размер: {ebook.FileSize} МБ");
    }

    class T9Book
    {
        public string Title;
        public string Author;
    }

    class T9PaperBook : T9Book
    {
        public int Pages;
    }

    class T9EBook : T9Book
    {
        public double FileSize;
    }

    // ============================================================
    // ЗАДАНИЕ 10
    // ============================================================

    static void Task10()
    {
        Console.WriteLine("ЗАДАНИЕ 10 — ДОМАШНИЕ ЖИВОТНЫЕ");
        Console.WriteLine();

        List<T10Pet> pets = new List<T10Pet>
        {
            new T10Dog(),
            new T10Cat(),
            new T10Parrot()
        };

        foreach (T10Pet pet in pets)
        {
            pet.Eat();
        }
    }

    class T10Pet
    {
        public virtual void Eat()
        {
            Console.WriteLine("Животное ест.");
        }
    }

    class T10Dog : T10Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Собака ест корм.");
        }
    }

    class T10Cat : T10Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Кошка ест рыбу.");
        }
    }

    class T10Parrot : T10Pet
    {
        public override void Eat()
        {
            Console.WriteLine("Попугай ест зерно.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 11
    // ============================================================

    static void Task11()
    {
        Console.WriteLine("ЗАДАНИЕ 11 — БАНКОВСКИЕ СЧЕТА");
        Console.WriteLine();

        T11SavingsAccount savings =
            new T11SavingsAccount(100000);

        savings.Deposit(20000);
        savings.AddInterest();

        Console.WriteLine("Сберегательный счет:");
        savings.ShowBalance();

        Console.WriteLine();

        T11CreditAccount credit =
            new T11CreditAccount(50000);

        credit.Withdraw(60000);

        Console.WriteLine("Кредитный счет:");
        credit.ShowBalance();
    }

    class T11BankAccount
    {
        protected double balance;

        public T11BankAccount(double balance)
        {
            this.balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Недостаточно средств.");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Баланс: {balance:F2} тг");
        }
    }

    class T11SavingsAccount : T11BankAccount
    {
        public T11SavingsAccount(double balance)
            : base(balance)
        {
        }

        public void AddInterest()
        {
            balance += balance * 0.05;
        }
    }

    class T11CreditAccount : T11BankAccount
    {
        public T11CreditAccount(double balance)
            : base(balance)
        {
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 12
    // ============================================================

    static void Task12()
    {
        Console.WriteLine("ЗАДАНИЕ 12 — ТРАНСПОРТНАЯ КОМПАНИЯ");
        Console.WriteLine();

        T12Transport[] transports =
        {
            new T12Car(),
            new T12Truck(),
            new T12Bus()
        };

        double distance = 100;

        foreach (T12Transport transport in transports)
        {
            Console.WriteLine(
                $"{transport.GetType().Name}: " +
                $"{transport.CalculateCost(distance)} тг");
        }
    }

    class T12Transport
    {
        public virtual double CalculateCost(double distance)
        {
            return 0;
        }
    }

    class T12Car : T12Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 50;
        }
    }

    class T12Truck : T12Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 100;
        }
    }

    class T12Bus : T12Transport
    {
        public override double CalculateCost(double distance)
        {
            return distance * 70;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 13
    // ============================================================

    static void Task13()
    {
        Console.WriteLine("ЗАДАНИЕ 13 — РАБОТНИКИ КОМПАНИИ");
        Console.WriteLine();

        T13Programmer programmer = new T13Programmer
        {
            BaseSalary = 300000,
            Projects = 2
        };

        T13Designer designer = new T13Designer
        {
            BaseSalary = 250000,
            Designs = 3
        };

        T13Manager manager = new T13Manager
        {
            BaseSalary = 350000,
            Employees = 5
        };

        Console.WriteLine(
            $"Программист: {programmer.GetSalary()} тг");

        Console.WriteLine(
            $"Дизайнер: {designer.GetSalary()} тг");

        Console.WriteLine(
            $"Менеджер: {manager.GetSalary()} тг");
    }

    class T13Employee
    {
        public double BaseSalary;
    }

    class T13Programmer : T13Employee
    {
        public int Projects;

        public double GetSalary()
        {
            return BaseSalary + Projects * 50000;
        }
    }

    class T13Designer : T13Employee
    {
        public int Designs;

        public double GetSalary()
        {
            return BaseSalary + Designs * 30000;
        }
    }

    class T13Manager : T13Employee
    {
        public int Employees;

        public double GetSalary()
        {
            return BaseSalary + Employees * 10000;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 14
    // ============================================================

    static void Task14()
    {
        Console.WriteLine("ЗАДАНИЕ 14 — СИСТЕМА ОБРАЗОВАНИЯ");
        Console.WriteLine();

        T14GraduateStudent student =
            new T14GraduateStudent
            {
                Name = "Алексей",
                Age = 23,
                Specialty = "Информатика",
                Course = 2,
                Thesis = "Искусственный интеллект",
                Supervisor = "Иван Петров"
            };

        student.ShowInfo();
    }

    class T14Person
    {
        public string Name;
        public int Age;
    }

    class T14Student : T14Person
    {
        public string Specialty;
        public int Course;
    }

    class T14GraduateStudent : T14Student
    {
        public string Thesis;
        public string Supervisor;

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Специальность: {Specialty}");
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Тема работы: {Thesis}");
            Console.WriteLine($"Руководитель: {Supervisor}");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 15
    // ============================================================

    static void Task15()
    {
        Console.WriteLine("ЗАДАНИЕ 15 — ВОЕННАЯ ТЕХНИКА");
        Console.WriteLine();

        T15MilitaryVehicle[] vehicles =
        {
            new T15Tank(),
            new T15Helicopter(),
            new T15ArmoredCar()
        };

        foreach (T15MilitaryVehicle vehicle in vehicles)
        {
            vehicle.Attack();
        }
    }

    class T15MilitaryVehicle
    {
        public virtual void Attack()
        {
            Console.WriteLine("Военная техника атакует.");
        }
    }

    class T15Tank : T15MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Танк атакует из пушки.");
        }
    }

    class T15Helicopter : T15MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Вертолет атакует с воздуха.");
        }
    }

    class T15ArmoredCar : T15MilitaryVehicle
    {
        public override void Attack()
        {
            Console.WriteLine("Бронеавтомобиль атакует.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 16
    // ============================================================

    static void Task16()
    {
        Console.WriteLine("ЗАДАНИЕ 16 — ИГРОВЫЕ ПЕРСОНАЖИ");
        Console.WriteLine();

        T16Character[] characters =
        {
            new T16Warrior
            {
                Name = "Воин",
                Health = 150,
                Damage = 30
            },

            new T16Mage
            {
                Name = "Маг",
                Health = 100,
                Damage = 40
            },

            new T16Archer
            {
                Name = "Лучник",
                Health = 120,
                Damage = 35
            }
        };

        foreach (T16Character character in characters)
        {
            character.Attack();
        }
    }

    class T16Character
    {
        public string Name;
        public int Health;
        public int Damage;

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} атакует.");
        }
    }

    class T16Warrior : T16Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} атакует мечом на {Damage} урона.");
        }
    }

    class T16Mage : T16Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} использует магию на {Damage} урона.");
        }
    }

    class T16Archer : T16Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} стреляет из лука на {Damage} урона.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 17
    // ============================================================

    static void Task17()
    {
        Console.WriteLine("ЗАДАНИЕ 17 — ЭЛЕКТРОННЫЕ УСТРОЙСТВА");
        Console.WriteLine();

        T17Device[] devices =
        {
            new T17Phone(),
            new T17Computer(),
            new T17Television()
        };

        foreach (T17Device device in devices)
        {
            device.TurnOn();
            device.TurnOff();
            Console.WriteLine();
        }
    }

    class T17Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Устройство включено.");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Устройство выключено.");
        }
    }

    class T17Phone : T17Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Телефон включается.");
        }
    }

    class T17Computer : T17Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Компьютер загружается.");
        }
    }

    class T17Television : T17Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Телевизор включается.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 18
    // ============================================================

    static void Task18()
    {
        Console.WriteLine("ЗАДАНИЕ 18 — ПЛАТЕЖИ");
        Console.WriteLine();

        T18Payment[] payments =
        {
            new T18CashPayment(),
            new T18CardPayment(),
            new T18OnlinePayment()
        };

        foreach (T18Payment payment in payments)
        {
            payment.Pay(10000);
        }
    }

    class T18Payment
    {
        public virtual void Pay(double amount)
        {
            Console.WriteLine($"Оплата: {amount} тг");
        }
    }

    class T18CashPayment : T18Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine(
                $"Оплата наличными: {amount} тг");
        }
    }

    class T18CardPayment : T18Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine(
                $"Оплата картой: {amount} тг");
        }
    }

    class T18OnlinePayment : T18Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine(
                $"Онлайн-оплата: {amount} тг");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 19
    // ============================================================

    static void Task19()
    {
        Console.WriteLine("ЗАДАНИЕ 19 — СОТРУДНИКИ С БОНУСАМИ");
        Console.WriteLine();

        T19Employee[] employees =
        {
            new T19Manager { Salary = 500000 },
            new T19Developer { Salary = 600000 },
            new T19SalesManager { Salary = 400000 }
        };

        foreach (T19Employee employee in employees)
        {
            Console.WriteLine(
                $"{employee.GetType().Name}: " +
                $"зарплата {employee.Salary} тг, " +
                $"бонус {employee.GetBonus()} тг");
        }
    }

    class T19Employee
    {
        public double Salary;

        public virtual double GetBonus()
        {
            return 0;
        }
    }

    class T19Manager : T19Employee
    {
        public override double GetBonus()
        {
            return Salary * 0.20;
        }
    }

    class T19Developer : T19Employee
    {
        public override double GetBonus()
        {
            return Salary * 0.15;
        }
    }

    class T19SalesManager : T19Employee
    {
        public override double GetBonus()
        {
            return Salary * 0.25;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 20
    // ============================================================

    static void Task20()
    {
        Console.WriteLine("ЗАДАНИЕ 20 — ЖИВОТНЫЕ ЗООПАРКА");
        Console.WriteLine();

        T20Animal[] animals =
        {
            new T20Lion(),
            new T20Elephant(),
            new T20Monkey(),
            new T20Tiger(),
            new T20Giraffe()
        };

        foreach (T20Animal animal in animals)
        {
            animal.Eat();
            animal.MakeSound();
            Console.WriteLine();
        }
    }

    class T20Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Животное ест.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук.");
        }
    }

    class T20Lion : T20Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Лев ест мясо.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Лев: Ррр!");
        }
    }

    class T20Elephant : T20Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Слон ест растения.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Слон трубит.");
        }
    }

    class T20Monkey : T20Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Обезьяна ест фрукты.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Обезьяна кричит.");
        }
    }

    class T20Tiger : T20Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Тигр ест мясо.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Тигр рычит.");
        }
    }

    class T20Giraffe : T20Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Жираф ест листья.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Жираф издает звук.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 21
    // ============================================================

    static void Task21()
    {
        Console.WriteLine("ЗАДАНИЕ 21 — АБСТРАКТНЫЕ ФИГУРЫ");
        Console.WriteLine();

        T21Shape[] shapes =
        {
            new T21Circle { Radius = 5 },
            new T21Rectangle { Width = 4, Height = 6 },
            new T21Triangle { Base = 8, Height = 5 },
            new T21Square { Side = 7 }
        };

        foreach (T21Shape shape in shapes)
        {
            Console.WriteLine(
                $"{shape.GetType().Name}: " +
                $"{shape.GetArea():F2}");
        }
    }

    abstract class T21Shape
    {
        public abstract double GetArea();
    }

    class T21Circle : T21Shape
    {
        public double Radius;

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class T21Rectangle : T21Shape
    {
        public double Width;
        public double Height;

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class T21Triangle : T21Shape
    {
        public double Base;
        public double Height;

        public override double GetArea()
        {
            return Base * Height / 2;
        }
    }

    class T21Square : T21Shape
    {
        public double Side;

        public override double GetArea()
        {
            return Side * Side;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 22
    // ============================================================

    static void Task22()
    {
        Console.WriteLine("ЗАДАНИЕ 22 — ИНТЕРНЕТ-МАГАЗИН");
        Console.WriteLine();

        T22Product[] products =
        {
            new T22Electronics
            {
                Name = "Телефон",
                Price = 200000
            },

            new T22Clothing
            {
                Name = "Куртка",
                Price = 50000
            },

            new T22Food
            {
                Name = "Продукты",
                Price = 10000
            }
        };

        foreach (T22Product product in products)
        {
            Console.WriteLine(
                $"{product.Name}: " +
                $"итоговая цена {product.GetFinalPrice():F2} тг");
        }
    }

    class T22Product
    {
        public string Name;
        public double Price;

        public virtual double GetFinalPrice()
        {
            return Price;
        }
    }

    class T22Electronics : T22Product
    {
        public override double GetFinalPrice()
        {
            return Price * 1.05;
        }
    }

    class T22Clothing : T22Product
    {
        public override double GetFinalPrice()
        {
            return Price * 0.90;
        }
    }

    class T22Food : T22Product
    {
        public override double GetFinalPrice()
        {
            return Price;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 23
    // ============================================================

    static void Task23()
    {
        Console.WriteLine("ЗАДАНИЕ 23 — СИСТЕМА ТРАНСПОРТА");
        Console.WriteLine();

        T23Transport[] transports =
        {
            new T23Car(),
            new T23Truck(),
            new T23Bus(),
            new T23Motorcycle()
        };

        foreach (T23Transport transport in transports)
        {
            transport.Move();

            Console.WriteLine(
                $"Расход: " +
                $"{transport.GetFuelConsumption()} л/100 км");

            Console.WriteLine();
        }
    }

    abstract class T23Transport
    {
        public abstract void Move();

        public abstract double GetFuelConsumption();
    }

    class T23Car : T23Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автомобиль едет.");
        }

        public override double GetFuelConsumption()
        {
            return 8;
        }
    }

    class T23Truck : T23Transport
    {
        public override void Move()
        {
            Console.WriteLine("Грузовик перевозит груз.");
        }

        public override double GetFuelConsumption()
        {
            return 20;
        }
    }

    class T23Bus : T23Transport
    {
        public override void Move()
        {
            Console.WriteLine("Автобус перевозит пассажиров.");
        }

        public override double GetFuelConsumption()
        {
            return 15;
        }
    }

    class T23Motorcycle : T23Transport
    {
        public override void Move()
        {
            Console.WriteLine("Мотоцикл едет.");
        }

        public override double GetFuelConsumption()
        {
            return 4;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 24
    // ============================================================

    static void Task24()
    {
        Console.WriteLine("ЗАДАНИЕ 24 — БОЛЬНИЦА");
        Console.WriteLine();

        T24MedicalWorker[] workers =
        {
            new T24Doctor { Name = "Иван" },
            new T24Nurse { Name = "Анна" },
            new T24Surgeon { Name = "Петр" }
        };

        foreach (T24MedicalWorker worker in workers)
        {
            worker.Work();
        }
    }

    class T24MedicalWorker
    {
        public string Name;

        public virtual void Work()
        {
            Console.WriteLine($"{Name} работает.");
        }
    }

    class T24Doctor : T24MedicalWorker
    {
        public override void Work()
        {
            Console.WriteLine(
                $"{Name} принимает пациентов.");
        }
    }

    class T24Nurse : T24MedicalWorker
    {
        public override void Work()
        {
            Console.WriteLine(
                $"{Name} ухаживает за пациентами.");
        }
    }

    class T24Surgeon : T24MedicalWorker
    {
        public override void Work()
        {
            Console.WriteLine(
                $"{Name} проводит операцию.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 25
    // ============================================================

    static void Task25()
    {
        Console.WriteLine("ЗАДАНИЕ 25 — СИСТЕМА СОТРУДНИКОВ");
        Console.WriteLine();

        T25Director director = new T25Director
        {
            Name = "Александр",
            Age = 45,

            Salary = 1000000,
            Company = "Tech Company",

            TeamSize = 50,
            Department = "IT",

            Car = "Toyota",
            Bonus = 300000
        };

        director.ShowPerson();
        director.ShowEmployee();
        director.ShowManager();
        director.ShowDirector();
    }

    class T25Person
    {
        public string Name;
        public int Age;

        public void ShowPerson()
        {
            Console.WriteLine(
                $"Имя: {Name}, возраст: {Age}");
        }
    }

    class T25Employee : T25Person
    {
        public double Salary;
        public string Company;

        public void ShowEmployee()
        {
            Console.WriteLine(
                $"Компания: {Company}, " +
                $"зарплата: {Salary} тг");
        }
    }

    class T25Manager : T25Employee
    {
        public int TeamSize;
        public string Department;

        public void ShowManager()
        {
            Console.WriteLine(
                $"Отдел: {Department}, " +
                $"сотрудников: {TeamSize}");
        }
    }

    class T25Director : T25Manager
    {
        public string Car;
        public double Bonus;

        public void ShowDirector()
        {
            Console.WriteLine(
                $"Автомобиль: {Car}, " +
                $"бонус: {Bonus} тг");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 26
    // ============================================================

    static void Task26()
    {
        Console.WriteLine("ЗАДАНИЕ 26 — ИГРА: ПЕРСОНАЖИ");
        Console.WriteLine();

        T26Character[] characters =
        {
            new T26Warrior
            {
                Name = "Воин",
                Health = 150
            },

            new T26Mage
            {
                Name = "Маг",
                Health = 100
            },

            new T26Archer
            {
                Name = "Лучник",
                Health = 120
            }
        };

        foreach (T26Character character in characters)
        {
            character.Attack();
            character.Defend();
            character.SpecialAttack();

            Console.WriteLine();
        }
    }

    abstract class T26Character
    {
        public string Name;
        public int Health;

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }

    class T26Warrior : T26Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} атакует мечом.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} защищается щитом.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} использует мощный удар.");
        }
    }

    class T26Mage : T26Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} атакует заклинанием.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} создает магический барьер.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} вызывает огненный шар.");
        }
    }

    class T26Archer : T26Character
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"{Name} стреляет из лука.");
        }

        public override void Defend()
        {
            Console.WriteLine(
                $"{Name} уклоняется от атаки.");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine(
                $"{Name} выпускает несколько стрел.");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 27
    // ============================================================

    static void Task27()
    {
        Console.WriteLine("ЗАДАНИЕ 27 — ФАЙЛЫ");
        Console.WriteLine();

        T27File[] files =
        {
            new T27TextFile
            {
                Name = "document.txt",
                Size = 2.5
            },

            new T27ImageFile
            {
                Name = "photo.jpg",
                Size = 5.7
            },

            new T27VideoFile
            {
                Name = "video.mp4",
                Size = 500
            }
        };

        foreach (T27File file in files)
        {
            file.Open();
        }
    }

    class T27File
    {
        public string Name;
        public double Size;

        public virtual void Open()
        {
            Console.WriteLine(
                $"Открыт файл: {Name}");
        }
    }

    class T27TextFile : T27File
    {
        public override void Open()
        {
            Console.WriteLine(
                $"Текстовый файл открыт: {Name}");
        }
    }

    class T27ImageFile : T27File
    {
        public override void Open()
        {
            Console.WriteLine(
                $"Изображение открыто: {Name}");
        }
    }

    class T27VideoFile : T27File
    {
        public override void Open()
        {
            Console.WriteLine(
                $"Видео открыто: {Name}");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 28
    // ============================================================

    static void Task28()
    {
        Console.WriteLine("ЗАДАНИЕ 28 — СИСТЕМА ОПЛАТЫ ЗАРПЛАТЫ");
        Console.WriteLine();

        List<T28Employee> employees =
            new List<T28Employee>
            {
                new T28HourlyEmployee
                {
                    Name = "Иван",
                    Hours = 160,
                    Rate = 2000
                },

                new T28SalariedEmployee
                {
                    Name = "Алексей",
                    MonthlySalary = 400000
                },

                new T28CommissionEmployee
                {
                    Name = "Олег",
                    Sales = 2000000,
                    CommissionRate = 0.10
                }
            };

        double total = 0;

        foreach (T28Employee employee in employees)
        {
            double salary = employee.CalculateSalary();

            Console.WriteLine(
                $"{employee.Name}: {salary:F2} тг");

            total += salary;
        }

        Console.WriteLine();
        Console.WriteLine(
            $"Общий фонд зарплаты: {total:F2} тг");
    }

    abstract class T28Employee
    {
        public string Name;

        public abstract double CalculateSalary();
    }

    class T28HourlyEmployee : T28Employee
    {
        public double Hours;
        public double Rate;

        public override double CalculateSalary()
        {
            return Hours * Rate;
        }
    }

    class T28SalariedEmployee : T28Employee
    {
        public double MonthlySalary;

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class T28CommissionEmployee : T28Employee
    {
        public double Sales;
        public double CommissionRate;

        public override double CalculateSalary()
        {
            return Sales * CommissionRate;
        }
    }

    // ============================================================
    // ЗАДАНИЕ 29
    // ============================================================

    static void Task29()
    {
        Console.WriteLine("ЗАДАНИЕ 29 — ПОЛИМОРФИЗМ + НАСЛЕДОВАНИЕ");
        Console.WriteLine();

        List<T29Animal> animals =
            new List<T29Animal>
            {
                new T29Dog(),
                new T29Cat(),
                new T29Cow(),
                new T29Lion(),
                new T29Bird()
            };

        foreach (T29Animal animal in animals)
        {
            animal.MakeSound();
        }
    }

    class T29Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine(
                "Животное издает звук.");
        }
    }

    class T29Dog : T29Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Собака: Гав!");
        }
    }

    class T29Cat : T29Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Кошка: Мяу!");
        }
    }

    class T29Cow : T29Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Корова: Му!");
        }
    }

    class T29Lion : T29Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Лев: Ррр!");
        }
    }

    class T29Bird : T29Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Птица: Чик-чирик!");
        }
    }

    // ============================================================
    // ЗАДАНИЕ 30 — АВТОПАРК
    // ============================================================

    static void Task30()
    {
        Console.WriteLine("ЗАДАНИЕ 30 — СИСТЕМА АВТОПАРКА");
        Console.WriteLine();

        List<T30Vehicle> vehicles =
            new List<T30Vehicle>();

        // Добавление транспорта

        vehicles.Add(
            new T30Car(
                "Toyota",
                180,
                12000000,
                4));

        vehicles.Add(
            new T30Truck(
                "Volvo",
                120,
                25000000,
                20));

        vehicles.Add(
            new T30Bus(
                "Mercedes",
                110,
                30000000,
                50));

        vehicles.Add(
            new T30ElectricCar(
                "Tesla",
                250,
                35000000,
                75));

        vehicles.Add(
            new T30Motorcycle(
                "Honda",
                220,
                8000000,
                600));

        Console.WriteLine("================================");
        Console.WriteLine("          АВТОПАРК");
        Console.WriteLine("================================");
        Console.WriteLine();

        foreach (T30Vehicle vehicle in vehicles)
        {
            vehicle.ShowInfo();
            vehicle.Move();
            Console.WriteLine();
        }

        // Удаление транспорта

        Console.WriteLine("================================");
        Console.WriteLine("Удаляем грузовик...");
        Console.WriteLine("================================");

        if (vehicles.Count > 1)
        {
            vehicles.RemoveAt(1);
        }

        Console.WriteLine();

        foreach (T30Vehicle vehicle in vehicles)
        {
            Console.WriteLine(
                $"В автопарке: {vehicle.Brand}");
        }

        // Самый быстрый

        T30Vehicle fastest =
            vehicles
                .OrderByDescending(v => v.Speed)
                .First();

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("САМЫЙ БЫСТРЫЙ");
        Console.WriteLine("================================");

        Console.WriteLine(
            $"Марка: {fastest.Brand}");

        Console.WriteLine(
            $"Скорость: {fastest.Speed} км/ч");

        // Самый дорогой

        T30Vehicle mostExpensive =
            vehicles
                .OrderByDescending(v => v.Price)
                .First();

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("САМЫЙ ДОРОГОЙ");
        Console.WriteLine("================================");

        Console.WriteLine(
            $"Марка: {mostExpensive.Brand}");

        Console.WriteLine(
            $"Цена: {mostExpensive.Price:N0} тг");

        // Расход топлива

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("РАСХОД ТОПЛИВА");
        Console.WriteLine("================================");

        foreach (T30Vehicle vehicle in vehicles)
        {
            Console.WriteLine(
                $"{vehicle.Brand}: " +
                $"{vehicle.GetFuelConsumption()} л/100 км");
        }

        // Средняя скорость

        double averageSpeed =
            vehicles.Average(v => v.Speed);

        Console.WriteLine();
        Console.WriteLine(
            $"Средняя скорость автопарка: " +
            $"{averageSpeed:F2} км/ч");

        // Общая стоимость

        double totalPrice =
            vehicles.Sum(v => v.Price);

        Console.WriteLine(
            $"Общая стоимость автопарка: " +
            $"{totalPrice:N0} тг");
    }

    abstract class T30Vehicle
    {
        public string Brand { get; set; }

        public double Speed { get; set; }

        public double Price { get; set; }

        public T30Vehicle(
            string brand,
            double speed,
            double price)
        {
            Brand = brand;
            Speed = speed;
            Price = price;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine(
                $"Марка: {Brand}");

            Console.WriteLine(
                $"Скорость: {Speed} км/ч");

            Console.WriteLine(
                $"Цена: {Price:N0} тг");
        }

        public abstract double GetFuelConsumption();

        public virtual void Move()
        {
            Console.WriteLine(
                $"{Brand} движется.");
        }
    }

    class T30Car : T30Vehicle
    {
        public int Doors { get; set; }

        public T30Car(
            string brand,
            double speed,
            double price,
            int doors)
            : base(brand, speed, price)
        {
            Doors = doors;
        }

        public override double GetFuelConsumption()
        {
            return 8;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Дверей: {Doors}");

            Console.WriteLine(
                $"Расход: {GetFuelConsumption()} л/100 км");
        }
    }

    class T30Truck : T30Vehicle
    {
        public double LoadCapacity { get; set; }

        public T30Truck(
            string brand,
            double speed,
            double price,
            double loadCapacity)
            : base(brand, speed, price)
        {
            LoadCapacity = loadCapacity;
        }

        public override double GetFuelConsumption()
        {
            return 20;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Грузоподъемность: " +
                $"{LoadCapacity} тонн");

            Console.WriteLine(
                $"Расход: {GetFuelConsumption()} л/100 км");
        }
    }

    class T30Bus : T30Vehicle
    {
        public int Seats { get; set; }

        public T30Bus(
            string brand,
            double speed,
            double price,
            int seats)
            : base(brand, speed, price)
        {
            Seats = seats;
        }

        public override double GetFuelConsumption()
        {
            return 15;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Мест: {Seats}");

            Console.WriteLine(
                $"Расход: {GetFuelConsumption()} л/100 км");
        }
    }

    class T30ElectricCar : T30Vehicle
    {
        public double BatteryCapacity { get; set; }

        public T30ElectricCar(
            string brand,
            double speed,
            double price,
            double batteryCapacity)
            : base(brand, speed, price)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override double GetFuelConsumption()
        {
            return 0;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Батарея: " +
                $"{BatteryCapacity} кВт⋅ч");

            Console.WriteLine(
                "Расход топлива: 0 л/100 км");
        }

        public override void Move()
        {
            Console.WriteLine(
                $"{Brand} движется " +
                "на электрическом двигателе.");
        }
    }

    class T30Motorcycle : T30Vehicle
    {
        public int EngineVolume { get; set; }

        public T30Motorcycle(
            string brand,
            double speed,
            double price,
            int engineVolume)
            : base(brand, speed, price)
        {
            EngineVolume = engineVolume;
        }

        public override double GetFuelConsumption()
        {
            return 4;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine(
                $"Объем двигателя: " +
                $"{EngineVolume} см³");

            Console.WriteLine(
                $"Расход: {GetFuelConsumption()} л/100 км");
        }
    }
}