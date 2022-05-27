// See https://aka.ms/new-console-template for more information
using antraOOP;


ReverseNums sol1 = new ReverseNums();
int[] numbers = sol1.generateNumbers(11);
sol1.reverse(numbers);
sol1.printNumbers(numbers);
Console.WriteLine();

FibonacciSeq sol2 = new FibonacciSeq();
Console.WriteLine(sol2.fibonacci(8));


Instructor ins1 = new Instructor();
ins1.JoinDate = new System.DateTime(1999, 1, 13, 3, 57, 32, 11);
ins1.setBonus();
Console.Write(ins1.bonus);

Student student1 = new Student();
student1.addCourse("Math", "A");
student1.addCourse("English", "B");
student1.addCourse("Biology", "A");
double gpa = student1.getGPA();
Console.Write(gpa);

Ball obj1 = new Ball(30, 50, 100, 150);
Ball obj2 = new Ball(30, 60, 90, 120);
obj1.pop();
Console.WriteLine(obj1.Size);
obj1.Throw();
obj2.Throw();
obj1.Throw();
obj2.Throw();
obj1.Throw();
obj2.Throw();
obj1.Throw();
obj2.Throw();
Console.WriteLine(obj1.numOfThrown());
Console.WriteLine(obj2.numOfThrown());
obj2.pop();
obj2.Throw();
Console.WriteLine(obj2.numOfThrown());

















