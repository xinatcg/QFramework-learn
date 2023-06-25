using QFrameworkUml.Command;
using QFrameworkUml.Rule;
using QFrameworkUml.Command;

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