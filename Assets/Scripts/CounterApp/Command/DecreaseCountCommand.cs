using QFramework.Command;
using QFramework.Rule;

namespace CounterApp
{
    public class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterAppModel>().Count.Value--;
        }
    }
}