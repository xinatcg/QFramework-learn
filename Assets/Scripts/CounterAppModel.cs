using QFramework;

namespace DefaultNamespace
{
    public class CounterAppModel: AbstractModel
    {
        public int Count = 0;
        protected override void OnInit()
        {
            this.Count = 0;
        }
    }
}