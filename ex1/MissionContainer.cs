// Yaara Fridchay 208644112
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public delegate double func(double val);
    public class FunctionsContainer
    {  
        // dictionary that contains all the functions
       private Dictionary<string, func> funcs = new Dictionary<string, func>();
        /**
         * Indexer 
         **/
        public func this [string funcName]
        {
            get
            {
                if (!funcs.ContainsKey(funcName)){
                    funcs[funcName] = val => val;
                }
                return funcs[funcName];
            }
            set
            {   
                    funcs[funcName] = value;
            } 
        }
        /**
         * The function return list with all the names of the missions in the container. 
         **/
        public List<string> getAllMissions()
        {
            return new List<string>(this.funcs.Keys);
        }
    }
}
