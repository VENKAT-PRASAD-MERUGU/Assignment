using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaimnOfResponsibility.ChainHanlder
{   
    public abstract class ExpenseApproveManger
    {
        protected ExpenseApproveManger expenseApproveManger{ get;set; }

        public void nextmanager(ExpenseApproveManger expenseApproveManger)
        {
            this.expenseApproveManger = expenseApproveManger;

        }

        public abstract void CanApproveExpenseManger(string item, int money);        
    }
}
