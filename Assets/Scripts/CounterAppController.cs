using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace QFramework.learn
{
    // Controller
    public class CounterAppController : MonoBehaviour
    {
        // View
        public Button BtnAdd;
        public Button BtnSub;
        public Text CountText;
        
        // Model
        public int mCount = 0;
        
        void Start()
        {
            // Attach the button click listener
            BtnAdd.onClick.AddListener((() =>
            {
                // Interaction logic
                mCount++;
                
                // Presentation logic
                UpdateView();
                
            })); 
            BtnSub.onClick.AddListener((() =>
            {
                // Interaction logic
                mCount--;
                
                // Presentation logic
                UpdateView();
                
            })); 
            UpdateView();
        }

        void UpdateView()
        {
            CountText.text = mCount.ToString();
        }
        

        void Update()
        {
        }
    }
}