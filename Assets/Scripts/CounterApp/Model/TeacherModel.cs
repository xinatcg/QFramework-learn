using System.Collections.Generic;
using QFramework.Model;

namespace CounterApp
{
    public class TeacherModel: AbstractModel
    {
        public List<string> TeacherNames = new List<string>()
        {
            "Carl",
            "David"
        };

        protected override void OnInit()
        {

        }
    }
}