using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodApp
{
    /// <summary>
    /// Anonymous Method is the way to create delegate instance without writing the  seperate method. It is method without name.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemp = new List<Employee>
            {
             new Employee{eid=101,ename="Avnish"},
             new Employee{eid=102,ename="Manish"},
             new Employee{eid=103,ename="Kavita"}
            };
            //Step 2
            //Predicate<Employee> objpredicate = new Predicate<Employee>(FindEmp);
            //Step -3 
            // AnonymousMethodApp.Employee emp = listemp.Find(empl => FindEmp(empl));
            Employee emp = listemp.Find(delegate (Employee empl) // Anonymous method example ..
           {
              return  empl.eid == 102;

           });
            Console.Write("Id :{0} , Name : {1}", emp.eid, emp.ename);

        }

               //step -1 
     /*   public static bool FindEmp(Employee emp)
        {
            if (emp.eid == 102)
                return true;
            else
                return false;
        } */
    }

    public class Employee
    {
        public int eid { get; set; }
        public string  ename { get; set; }
    }
}
