using QFramework;

namespace DefaultNamespace
{
    public class CounterApp: Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new CounterAppModel());
        }
    }
}