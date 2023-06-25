using System;
using QFrameworkUml.TypeEvent;
using UnityEngine;

namespace CounterApp.Event
{
    public class TypeEventSystemBasicExample : MonoBehaviour
    {
        public struct TestEventA
        {
            public int Age;
        }

        private void Start()
        {
            TypeEventSystem.Global.Register<TestEventA>(e => { Debug.Log("TypeEvent Basic" + e.Age); })
                .UnRegisterWhenGameObjectDestroyed(gameObject); // better unregister way
            
            // traditional way event register 1
            /*TypeEventSystem.Global.Register<TestEventA>(OnEventA);*/
        }

        // traditional way event register 2
        /*void OnEventA(TestEventA eventA)
        {
            
        }*/

        // traditional way event register 3
        /*private void OnDestroy()
        {
            TypeEventSystem.Global.UnRegister<TestEventA>(OnEventA);
        }*/

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TypeEventSystem.Global.Send(new TestEventA()
                {
                    Age = 18
                });
            }

            if (Input.GetMouseButtonDown(1))
            {
                TypeEventSystem.Global.Send(new TestEventA()
                {
                });
            }
        }
    }
}