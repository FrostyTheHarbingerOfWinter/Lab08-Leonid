// int lessonNumber = 5;
// int totalLesson = 1;

// while (lessonNumber >= totalLesson)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");



// Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");



// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }




// string correctPassword = "qwerty123";

// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }



// string answer;

// do
// {
//     Console.Write("введите дату посещения (например, 01.09):");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

