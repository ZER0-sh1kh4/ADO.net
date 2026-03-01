

using System;
using System.Collections.Generic;

class User
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();

        users.Add(new User { Name = "Aryan", Age = 22 });
        users.Add(new User { Name = "Mohit", Age = 32 });
        users.Add(new User { Name = "Sushant", Age = 68 });
        users.Add(new User { Name = "Ritik", Age = 63 });
        users.Add(new User { Name = "Sahil", Age = 52 });

        foreach (var user in users)
        {
            Console.WriteLine($"User Name: {user.Name}, Age: {user.Age}");
        }
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(45);
        queue.Enqueue(55);
        queue.Enqueue(65);
        queue.Enqueue(75);
        queue.Enqueue(25);
        foreach (var item in queue)
        {
            Console.WriteLine(item);   
        }
        while (queue.Count > 0)
        {
            int value = queue.Dequeue();  
            Console.WriteLine(value);
        }

    }


}





