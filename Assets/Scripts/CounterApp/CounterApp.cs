using CounterApp.Utility;
using QFramework;
using QFramework.Architecture;

namespace CounterApp
{
    public class CounterApp: Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new CounterAppModel());
            
            this.RegisterUtility(new Storage());
            
            this.RegisterSystem(new AchievementSystem());
            
            // Test Query
            this.RegisterModel(new StudentModel());
            this.RegisterModel(new TeacherModel());
        }
    }
}