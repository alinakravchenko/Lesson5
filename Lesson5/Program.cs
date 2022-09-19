using System;
using System.Data;
Worker worker = new Worker("Сергеев Сергей Сергеевич", DateTime.Now, "+792892854945", "serge@mail.ru", "Охранник", "Бдительность", 20000);
//Console.WriteLine("Зарплата {Worker.FIO} на должности {worker.JOb}{worker.Salary}");
//worker += 3000;
//Console.WriteLine("Зарплата {Worker.FIO} на должности {worker.JOb}{worker.Salary}");
//worker -= 7000;
Worker worker1 = new Worker("Сергеев Сергей Сергеевич", DateTime.Now, "+792892854945", "serge@mail.ru", "Охранник", "Бдительность", 20000);
Console.WriteLine($"Зарплата братьев равна {worker == worker1}");
Console.WriteLine($"Зарплата братьев не равна {worker != worker1}");
worker += 1000;
Console.WriteLine($"Зарплата Сергея больше Антона {worker > worker1}");
Console.WriteLine($"Зарплата Сергея меньше Антона {worker < worker1}");
Console.WriteLine($"Братья Равны {worker.Equals(worker1)}");


class Worker

{
    public string FIO { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Job { get; set; }
    public string JobDescription { get; set; }

    public int Salary { get; set; }

    public Worker(string fio, DateTime dateofbirth, string phone, string email, string job, string jobdescription, int salary)
    {
        FIO = fio;
        DateOfBirth = dateofbirth;
        Phone = phone;
        Email = email;
        Job = job;
        JobDescription = jobdescription;
        Salary = salary;
    }
    public static Worker operator +(Worker a, int b )
    {

        a.Salary += b;
        return a;
    }
    public static int operator +(int b, Worker a)
    {
        return b + a.Salary;
    }
    public static Worker operator -(Worker a, int b)
    {

        a.Salary += b;
        return a;
    }
    public static int operator -(int b, Worker a)
    {
        return b + a.Salary;
    }
    public static bool operator ==(Worker a, Worker b)
    {
       return a.Salary == b.Salary? true : false;
    }
    public static bool operator !=(Worker a, Worker b)
    {
        return a.Salary != b.Salary ? true : false;
    }
    public static bool operator >(Worker a, Worker b)
    {
        return a.Salary > b.Salary ? true : false;
    }
    public static bool operator <(Worker a, Worker b)
    {
        return a.Salary < b.Salary ? true : false;
    }

    public override bool Equals(object obj)
    {
        return this.ToString()==obj.ToString();
    }
    public override int GetHashCode()
    {
        return this.GetHashCode();
    }
}

class City
{

}

class CreditCard
{

}

class Matrix
{

}