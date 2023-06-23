using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace QFramework.learn
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
                MAppModel.Count++;
                
                // Presentation logic
                UpdateView();
                
            })); 
            BtnSub.onClick.AddListener((() =>
            {
                // Interaction logic
                MAppModel.Count--;
                
                // Presentation logic
                UpdateView();
                
            })); 
            UpdateView();
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