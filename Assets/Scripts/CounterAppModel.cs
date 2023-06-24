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

        private Storage mStorage;
        public int Count
        {
            get => mCount;
            set
            {
                if (mCount != value)
                {
                    mCount = value;
                    mStorage.SaveInt(nameof(Count), Count);
                }
            }
        }
        protected override void OnInit()
        {
            mStorage = this.GetUtility<Storage>();

            Count = mStorage.LoadInt(nameof(Count));

            // CounterApp.Interface.RegisterEvent<CountChangeEvent>(e =>
            // {
            //     mStorage.SaveInt(nameof(Count), Count);
            // });
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