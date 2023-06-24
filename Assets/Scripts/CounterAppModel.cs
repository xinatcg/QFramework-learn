using QFramework;
using QFramework.Model;
using UnityEngine;

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
                    PlayerPrefs.SetInt(nameof(Count), mCount);
                }
            }
        }
        protected override void OnInit()
        {
            Count = PlayerPrefs.GetInt(nameof(Count), mCount);
        }
    }
}