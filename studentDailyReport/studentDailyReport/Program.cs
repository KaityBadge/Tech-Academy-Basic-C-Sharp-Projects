int num1 = 6;
int num2 = 3;
Console.WriteLine(num1 % num2);
Console.ReadLine();



Console.WriteLine("The Tech Academy");
Console.WriteLine("Student Daily Report");

//Im using the new line code \n to give space between each question

//writes the question in the console 
Console.WriteLine("\nWhat is your name?");
//the written response is saved as a string variable called studentName
string studentName = Console.ReadLine();

//writes the question in the console
Console.WriteLine("\nWhat course are you on?");
//the written response is saved as a string variable called currentCourse
string currentCourse = Console.ReadLine();

//writes the questions in the console
Console.WriteLine("\nWhat page number?");
//stores the response string because console.readline can only take in string values
string pageNumber = Console.ReadLine();
//converts the string to int (whole number)
//the student must write a number 
int pageNum = Convert.ToInt32(pageNumber);


Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\"");
string needHelp = Console.ReadLine();
//converts the response from string to boolean data type.
//The student must write true or false exactly as written in the question
bool helpStudent = Convert.ToBoolean(needHelp);


Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
string studentExperience = Console.ReadLine();


Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
string studentFeedback = Console.ReadLine();


Console.WriteLine("\nHow many hours did you study today?");
string hoursStudied = Console.ReadLine();
//converts the string to int data type
//student must write a number not spell it out
int studyHours = Convert.ToInt32(hoursStudied);


Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
Console.ReadLine();