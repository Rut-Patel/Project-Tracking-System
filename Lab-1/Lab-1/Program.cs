/************************************
 * Name:- Rut Patel
 * NET DEVELOPMENT-II
 * Lab-1
 * Class Defination.
**********************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Program
    {
        private string projectName;
        private int budget;
        private int amountSpent;
        private int hoursremaining;
        private string status;

        public Program(string projectName, int budget, int amountSpent, int hoursremaining, string status)
        {
            this.projectName = projectName;
            this.budget = budget;
            this.amountSpent = amountSpent;
            this.hoursremaining = hoursremaining;
            this.status = status;
        }

        #region "Accessor And mutators."
        public string ProjectName
        {
            get { return this.projectName; }
            set { this.projectName = value; }
        }

        public int Budget
        {
            get {return this.budget;}
            set { this.budget = value; }
        }

        public int AmountSpent
        {
            get { return this.amountSpent; }
            set { this.amountSpent = AmountSpent; }
        }



        public int HoursRemaining
        {
            get { return this.hoursremaining; }
            set { this.hoursremaining = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

#endregion       


    }

}
