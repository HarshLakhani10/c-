public class Student
{
    public string Name;

    public static string School = "ppsu";

    public void ShowName()
    {
        System.Console.WriteLine("Hello : " + this.Name + "And School is : " + School);
    }

    public static void ShowSchool()
    {
        System.Console.WriteLine("Default School is : " + School);
    }

}