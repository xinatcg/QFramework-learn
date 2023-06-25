using CounterApp;
using QFrameworkUml.Rule;
using QFrameworkUml.System;
using UnityEngine;

namespace CounterApp
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