using DefaultNamespace;
using QFramework.Architecture;
using QFramework.Command;
using QFramework.Controller;
using QFramework.Rule;
using QFramework.TypeEvent;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using NotImplementedException = System.NotImplementedException;

namespace QFramework.learn
{
    // Command
    public class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            var model = this.GetModel<CounterAppModel>();
            model.Count.Value++;
        }
    }

    public class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterAppModel>().Count.Value--;
        }
    }

    // Controller
    public class CounterAppController : MonoBehaviour, IController
    {
        // View
        public Button BtnAdd;
        public Button BtnSub;
        public Text CountText;

        // Model
        public CounterAppModel MAppModel;


        void Start()
        {
            MAppModel = this.GetModel<CounterAppModel>();

            // Attach the button click listener
            BtnAdd.onClick.AddListener((() =>
            {
                // Interaction logic
                this.SendCommand<IncreaseCountCommand>();
            }));
            BtnSub.onClick.AddListener((() =>
            {
                // Interaction logic
                this.SendCommand<DecreaseCountCommand>();
            }));

            // Presentation logic
            MAppModel.Count.RegisterWithInitValue(_ => { UpdateView(); })
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        void UpdateView()
        {
            CountText.text = MAppModel.Count.ToString();
        }

        public IArchitecture GetArchitecture()
        {
            return CounterApp.Interface;
        }

        private void OnDestroy()
        {
            MAppModel = null;
        }
    }
}