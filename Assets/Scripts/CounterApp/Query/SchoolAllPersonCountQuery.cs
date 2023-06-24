using QFramework.Query;
using QFramework.Rule;

namespace CounterApp.Query
{
    public class SchoolAllPersonCountQuery : AbstractQuery<int>
    {
        protected override int OnDo()
        {
            return this.GetModel<StudentModel>().StudentNames.Count +
                   this.GetModel<TeacherModel>().TeacherNames.Count;
        }
    }
}