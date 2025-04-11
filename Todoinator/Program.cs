Console.WriteLine("Willkommen beim Todoinator!");
// var meineCooleListe = new List<string>();
var todoList = new List<TodoItem>();
while (true)
{
    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"Index {i + 1}: {todoList[i]}");
    }
    Console.WriteLine("""
    1. Neues Todo
    2. Todo abhaken
    """);
    var userMenuChoice = Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            // Todo erstellen
            Console.WriteLine("Was ist das Todo?");
            var todoDescription = Console.ReadLine();
            Console.WriteLine("""
             Wie wichtig?
             1 => Hohe Prio
             2 => Normale Prio
             3 => Niedrige Prio
             """);
            var todoPrio = Console.ReadLine();
            var newTodo = new TodoItem();
            newTodo.Description = todoDescription;
            newTodo.Prio = Convert.ToInt32(todoPrio);
            todoList.Add(newTodo);
            break;
        case "2":
            // Todo abhaken
            Console.WriteLine("Welches Todo möchtest do löschen?");
            var indexToDelete = Convert.ToInt32(Console.ReadLine());
            todoList.RemoveAt(indexToDelete - 1);
            break;
        default:
            // Nicht definierter Input eg. "hamster"
            break;
    }

    Console.Clear();
}