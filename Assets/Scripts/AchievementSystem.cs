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

            this.RegisterEvent<CountChangeEvent>(e =>
            {
                if (model.Count == 10)
                {
                    Debug.Log($"Triggered Click Master Achievement: {model.Count}");
                }
                else if (model.Count == 20)
                {
                    Debug.Log($"Triggered Click Expert Achievement: {model.Count}");
                }
            });
        }
    }
}