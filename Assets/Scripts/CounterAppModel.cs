using QFramework;
using QFramework.BindableProperty;
using QFramework.learn;
using QFramework.Rule;
using UnityEngine;
using AbstractModel = QFramework.Model.AbstractModel;

namespace DefaultNamespace
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

    public class Storage : QFramework.Utility.IUtility
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public int LoadInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }
    }
}