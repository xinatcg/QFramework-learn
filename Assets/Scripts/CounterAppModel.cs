using QFramework;
using QFramework.learn;
using QFramework.Rule;
using QFrameworkSingleFile;
using UnityEngine;
using AbstractModel = QFramework.Model.AbstractModel;

namespace DefaultNamespace
{
    public class CounterAppModel: AbstractModel
    {
        private int mCount;

        public int Count
        {
            get => mCount;
            set
            {
                if (mCount != value)
                {
                    mCount = value;
                    this.GetUtility<Storage>().SaveInt(nameof(Count), Count);
                }
            }
        }
        protected override void OnInit()
        {
            var storage = this.GetUtility<Storage>();

            Count = storage.LoadInt(nameof(Count));

            CounterApp.Interface.RegisterEvent<CountChangeEvent>(e =>
            {
                storage.SaveInt(nameof(Count), Count);
            });

        }
    }

    public class Storage :  QFramework.Utility.IUtility
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