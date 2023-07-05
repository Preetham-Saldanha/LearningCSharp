using System.Globalization;
using System.Text;

namespace Test2
{
   
public static void printDepName(List<Department> dep){

Console.WriteLine(dep.Name);

if(dep.SubDepartment.size()===0){
return;
}

foreach(var sub in dep.SubDepartment){
printDepName(sub);

}

}

public static void Main(string[] args){


            //Date Time Question
            DateTime current= DateTime.Now;
            CultureInfo culture = CultureInfo.InvariantCulture;
            Calendar calendar=culture.Calendar;
            int weekNumber = calendar.GetWeekOfYear(current, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
            Console.WriteLine(weekNumber);


            //CSV Question
            
            List<Person> list = new List<Person>
            {
                new Person { PersonId = 1, FirstName = "A", LastName = "B" },
                new Person { PersonId = 2, FirstName = "C", LastName = "D" },
                new Person { PersonId = 3, FirstName = "E", LastName = "F" }
            };

            StringBuilder sb = new StringBuilder();
            foreach (Person p in list)
            {
                sb.Append(p.PersonId + ";" + p.FirstName + ";" + p.LastName + "\n");
            }

            Console.WriteLine(sb.ToString());
       } 
    
}