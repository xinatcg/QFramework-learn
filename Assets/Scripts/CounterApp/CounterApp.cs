using CounterApp.Utility;
using QFrameworkUml.Architecture;
using QFrameworkUml.Command;
using UnityEngine;

namespace CounterApp
{
    public class CounterApp: Architecture<CounterApp>
    {
        protected override void Init()
        {
            this.RegisterModel(new CounterAppModel());
            
            this.RegisterUtility(new Storage());
            
            this.RegisterSystem(new AchievementSystem());
            
            // Test Query
            this.RegisterModel(new StudentModel());
            this.RegisterModel(new TeacherModel());
        }

        // When invoke Command for this Architecture, will invoke this method
        protected override void ExecuteCommand(ICommand command)
        {
            Debug.Log("Before " + command.GetType().Name + "Execute");
            base.ExecuteCommand(command);
            Debug.Log("After " + command.GetType().Name + "Execute");
        }
    }
}