//Yaara Fridchay 208644112
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class SingleMission : IMission
    {
        private func singleM;
        /**
         * Constructor.
         **/
        public SingleMission(func function, string name)
        {
            this.singleM = function;
            this.Name = name;
        }
        /**
         * The function return the name of the func.
         */
        public string Name { get; }
        /**
         * The function return the type of the func = single.
         **/
        public string Type { get { return "Single"; } }

        public event EventHandler<double> OnCalculate;

        /**
         * The function calculate the mission.
         **/
        public double Calculate(double value)
        {
            double calc = value;
            if (singleM != null)
            {
                //if singleM is func
               calc = singleM(value);
            }
            //invoke everyone
            OnCalculate?.Invoke(this, calc);
            return calc;
        }
    }
}
