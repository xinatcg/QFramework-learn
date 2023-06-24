using QFramework.Command;
using QFramework.Rule;

namespace CounterApp
{
    public class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            var model = this.GetModel<CounterAppModel>();
            model.Count.Value++;
        }
    }
}