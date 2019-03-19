// Yaara  Fridchay 208644112
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class ComposedMission : IMission
    {
        private List<func> myFuncs=new List<func>();
        public func composeM;
        /**
         * Constructor.
         **/
        public ComposedMission(string name)
        {
            this.Name = name;
        }
        /**
         * The function return the name of the func.
         */
        public string Name { get; }
        /**
        * The function return the type of the func = single.
        **/
        public string Type { get { return "Composed"; } }

        /**
         * The function add function(=mission) to the composed mission.
         **/
        public ComposedMission Add(func calc)
        {
            this.myFuncs.Add(calc);
            return this;
        }

        public event EventHandler<double> OnCalculate;

        /**
         * the function calculate all the missions of the composed Mission
         **/
        public double Calculate(double value)
        {
            //calculate all the missions
            for(int i = 0; i < this.myFuncs.Count; i++)
            {
                value = this.myFuncs[i](value);
            }
            // invoke everyone
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
