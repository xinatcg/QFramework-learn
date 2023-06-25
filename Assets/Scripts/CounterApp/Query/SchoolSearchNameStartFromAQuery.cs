using System.Collections.Generic;
using QFrameworkUml.Query;
using QFrameworkUml.Rule;

namespace CounterApp.Query
{
    public class SchoolSearchNameStartFromAQuery : AbstractQuery<List<string>>
    {
        protected override List<string> OnDo()
        {
            List<string> studentResult =
                this.GetModel<StudentModel>().StudentNames.FindAll(x => x.ToLower().StartsWith("a"));
            List<string> teacherResult =
                this.GetModel<TeacherModel>().TeacherNames.FindAll(x => x.ToLower().StartsWith("a"));
            studentResult.AddRange(teacherResult);
            return studentResult;
        }
    }
}