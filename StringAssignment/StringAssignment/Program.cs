using System;
using System.Text;


class StringBuilderAssignment 
{
    static void Main()
    {

        /////concatenating three strings
        //string fname = "Kaity";
        //string lname = "Badgley";
        //string birthYear = "1995";

        //String Concat = "My name is " + fname + " " + lname + " and I was born in " + birthYear;

        //Console.WriteLine(Concat);
        //Console.Read();

        /////convert string to uppercase
        //string fname = "kaitlyn";
        //fname = fname.ToUpper();

        //Console.WriteLine(fname);
        //Console.Read();


        ///creates Stringbuilder and builds a paragraph of text, one sentence at a time.///

        // creates stringbuilder objects, the string will be appended (added) later
        StringBuilder sb = new StringBuilder();

        //Append(add) string to string builder
        sb.Append("My first name is ... ");
        sb.AppendLine(); //left empty because it is added to the end of the first append
        //The following append lines will be printed on new lines
        sb.AppendLine("Kaity"); 
        sb.AppendLine("This is all new to me."); 
        Console.WriteLine(sb);

        Console.Read();


        
    }
}
