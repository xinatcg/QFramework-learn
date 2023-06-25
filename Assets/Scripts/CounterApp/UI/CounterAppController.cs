using CounterApp;
using QFrameworkUml.Architecture;
using QFrameworkUml.Command;
using QFrameworkUml.Controller;
using QFrameworkUml.Rule;
using QFrameworkUml.TypeEvent;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using NotImplementedException = System.NotImplementedException;

namespace CounterApp
{
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
            return global::CounterApp.CounterApp.Interface;
        }

        private void OnDestroy()
        {
            MAppModel = null;
        }
    }
}