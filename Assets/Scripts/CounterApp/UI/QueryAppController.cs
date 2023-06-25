using CounterApp.Query;
using QFrameworkUml.Architecture;
using QFrameworkUml.Controller;
using QFrameworkUml.Rule;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    public class QueryAppController: MonoBehaviour, IController
    {
        
        // View
        public Button BtnQuery;
        public Text QueryResult;
        public IArchitecture GetArchitecture()
        {
            return global::CounterApp.CounterApp.Interface;
        }

        void Start()
        {
            // Attach the button click listener
            BtnQuery.onClick.AddListener((() =>
            {
                // Interaction logic
                var query = new SchoolAllPersonCountQuery();
                var result = this.SendQuery(query);
                QueryResult.text = result.ToString();

                var query2 = new SchoolSearchNameStartFromAQuery();
                var result2 = this.SendQuery(query2);
                QueryResult.text += (" " + string.Join(",", result2));
                
            }));
        }
    }
}