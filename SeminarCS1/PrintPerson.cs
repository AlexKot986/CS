
using System.Text;

namespace SeminarCS1
{
    internal static class PrintPerson
    {
        public static void PrintGrandMothers(this FamilyMambers person)
        {
            int counter = 0;
            StringBuilder sb = new();
            sb.Append("---------------------------------------------\n");
            sb.Append(person.FullName + " все бабушки:\n");
            foreach (FamilyMambers fm in person.GetGrandMothers())
                if (fm is not null)
                    sb.Append(string.Format("{0}. {1}\n", ++counter, fm.FullName));
            sb.Append("---------------------------------------------");
            Console.WriteLine(sb.ToString());
        }
        public static void PrintGrandFathers(this FamilyMambers person)
        {
            int counter = 0;
            StringBuilder sb = new();
            sb.Append("---------------------------------------------\n");
            sb.Append(person.FullName + " все дедушки:\n");
            foreach (FamilyMambers fm in person.GetGrandFathers())
                if (fm is not null) 
                    sb.Append(string.Format("{0}. {1}\n", ++counter, fm.FullName));
            sb.Append("---------------------------------------------");
            Console.WriteLine(sb.ToString());
        }
        public static void PrintCloseRelative(this FamilyMambers person)
        { 
            StringBuilder sb = new();
            sb.Append("---------------------------------------------\n");
            sb.Append(person.FullName + " супруг:\n");
            sb.Append(string.Format("-  {0}\n", person.GetCloseRelative().FullName));
            sb.Append("---------------------------------------------");
            Console.WriteLine(sb.ToString());
        }
        public static void PrintChildren(this FamilyMambers person)
        {
            int counter = 0;
            StringBuilder sb = new();
            sb.Append("---------------------------------------------\n");
            sb.Append(person.FullName + " дети:\n");
            foreach (FamilyMambers fm in person.Children)
                sb.Append(string.Format("{0}. {1}\n", ++counter, fm.FullName));
            sb.Append("---------------------------------------------");
            Console.WriteLine(sb.ToString());
        }
    }
}
