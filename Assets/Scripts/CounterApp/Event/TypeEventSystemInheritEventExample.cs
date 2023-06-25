using System;
using QFramework.TypeEvent;
using UnityEngine;

namespace CounterApp.Event
{
    public class TypeEventSystemInheritEventExample : MonoBehaviour
    {
        public interface IEventA
        {
            public int GetAge();
        }

        public struct EventA : IEventA
        {
            public int Age;
            public int GetAge()
            {
                return Age;
            }
        }
        
        public struct EventB : IEventA
        {
            public int Age;
            public int GetAge()
            {
                return Age;
            }
        }

        private void Start()
        {
            TypeEventSystem.Global.Register<IEventA>(e =>
                {
                    if (e is EventA)
                    {
                        Debug.Log("TypeEvent Inherit EventA " + e.GetAge());
                    }
                    if (e is EventB)
                    {
                        Debug.Log("TypeEvent Inherit EventB " + e.GetAge());
                    }
                })
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TypeEventSystem.Global.Send<IEventA>(new EventA()
                {
                    Age = 18
                });
            }

            if (Input.GetMouseButtonDown(1))
            {
                TypeEventSystem.Global.Send<IEventA>(new EventB()
                {
                    Age = 0
                });
            }
        }
    }
}