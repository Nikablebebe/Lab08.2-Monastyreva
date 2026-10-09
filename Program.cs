// ЗАДАЧА А

// int n = 5; 
// int i = 1; 

// while (i <= 10)
// {
//    Console.WriteLine($"{n} x {i} = {n * i}");
//    i = i + 1; 
// }


// ЗАДАЧА Б

// int count = 0; 
// Console.WriteLine("Вводите имена учеников. Для остановки введите 'конец'.");
// string name = Console.ReadLine();

// while (name != "конец")
// {
//     count = count + 1; 
//     name = Console.ReadLine(); 
// }

// Console.WriteLine($"Введено имен: {count}");
    
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//ВАРИАНТ 5

//  int correctCode = 1234; 
// while (true) 
// {
//     Console.Write("Введите код домофона: ");
//     int input = int.Parse(Console.ReadLine());

//     if (input == correctCode)
//     {
//         Console.WriteLine("Дверь открыта");
//         break; 
//     } else
//     {
//          Console.WriteLine("Неверный код, попробуйте снова.");
//      }
// }