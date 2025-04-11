Console.WriteLine("Willkommen beim Todoinator"!);
while(true)

{
    Console.WriteLine("""
    1.Neues Todo
    2. ToDo abhaken
    """);
    var userMenuChoice = Console.ReadLine();
    switch(userMenuChoice)
    {

        case "1":
            //ToDo wird erstellt
            break;

        case "2":
            //ToDo abhaken
            break;

        default:
            //undefinierter Input nur 1 oder 2 erlaubt
            break;

            

    }
}
