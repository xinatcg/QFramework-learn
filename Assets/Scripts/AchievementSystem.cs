using QFramework.learn;
using QFramework.Rule;
using QFramework.System;
using UnityEngine;

namespace DefaultNamespace
{
    public class AchievementSystem : AbstractSystem
    {
        protected override void OnInit()
        {
            var model = this.GetModel<CounterAppModel>();

            model.Count.Register(count =>
            {
                if (count == 10)
                {
                    Debug.Log($"Triggered Click Master Achievement: {count}");
                }
                else if (count == 20)
                {
                    Debug.Log($"Triggered Click Expert Achievement: {count}");
                }
            });
        }
    }
}