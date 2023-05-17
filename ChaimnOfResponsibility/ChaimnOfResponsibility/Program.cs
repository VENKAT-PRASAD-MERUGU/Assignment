using ChaimnOfResponsibility.Concreteimplementer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaimnOfResponsibility
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            SeniorManager sm=new SeniorManager();
            VicePresident vp=new VicePresident();
            Ceo ceo=new Ceo();  
            sm.nextmanager(vp);
            vp.nextmanager(ceo);
            sm.CanApproveExpenseManger("lappy", 5000);
            
            Console.ReadLine(); 

        }
    }
}
