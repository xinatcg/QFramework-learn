using QFramework;
using QFramework.BindableProperty;
using CounterApp;
using CounterApp.Utility;
using QFramework.Rule;
using UnityEngine;
using AbstractModel = QFramework.Model.AbstractModel;

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