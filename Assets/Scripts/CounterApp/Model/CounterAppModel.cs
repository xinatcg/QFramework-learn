using QFrameworkUml.BindableProperty;
using CounterApp.Utility;
using QFrameworkUml.Rule;
using AbstractModel = QFrameworkUml.Model.AbstractModel;

namespace CounterApp
{
    public class CounterAppModel : AbstractModel
    {
        public BindableProperty<int> Count { get; } = new BindableProperty<int>();

        protected override void OnInit()
        {
            var storage = this.GetUtility<Storage>();

            Count.SetValueWithoutEvent(storage.LoadInt(nameof(Count)));

            Count.Register(newCount => { storage.SaveInt(nameof(Count), newCount); });
        }
    }


}