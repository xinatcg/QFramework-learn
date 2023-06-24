using System.Collections.Generic;
using QFramework.Model;

namespace CounterApp
{
    public class StudentModel: AbstractModel
    {
        public List<string> StudentNames = new List<string>()
        {
            "Alice",
            "Bob"
        };

        protected override void OnInit()
        {

        }
    }
}