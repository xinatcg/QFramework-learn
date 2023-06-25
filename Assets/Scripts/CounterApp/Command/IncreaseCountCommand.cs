using QFrameworkUml.Command;
using QFrameworkUml.Rule;
using QFrameworkUml.Command;

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