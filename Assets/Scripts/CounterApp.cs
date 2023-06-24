using QFramework;
using QFramework.Architecture;

namespace DefaultNamespace
{
    public class CounterApp: Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new CounterAppModel());
            
            this.RegisterUtility(new Storage());
            
            this.RegisterSystem(new AchievementSystem());
        }
    }
}