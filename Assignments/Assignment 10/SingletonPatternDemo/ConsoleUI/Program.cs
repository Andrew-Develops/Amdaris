using ConsoleUI;



Classroom obj = Classroom.GetClassroomInstanceEarly();
obj.PrintClassroom();
obj.GetMessage();

Classroom.GetClassroomInstanceLazy().PrintClassroom();


Console.WriteLine();