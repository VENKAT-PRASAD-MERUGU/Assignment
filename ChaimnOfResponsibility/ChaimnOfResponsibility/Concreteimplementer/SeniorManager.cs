using ChaimnOfResponsibility.ChainHanlder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaimnOfResponsibility.Concreteimplementer
{
    public class SeniorManager : ExpenseApproveManger
    {
        private readonly int limitCanApprove = 10000;
        public override void CanApproveExpenseManger(string item, int money)
        {
            if (money < limitCanApprove)
            {
                Console.WriteLine("Approved by Senior Manager for Expense of " + item + " with cost :" + money.ToString());
            }

            else
                expenseApproveManger.CanApproveExpenseManger(item, money);
        }
    }
}
