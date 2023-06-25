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
            TypeEventSystem.Global.Register<IEventA>(e => { Debug.Log("TypeEvent Inherit" + e.GetAge()); })
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TypeEventSystem.Global.Send<IEventA>(new EventB()
                {
                    Age = 18
                });

                // 无效
                TypeEventSystem.Global.Send<EventB>();
            }

            if (Input.GetMouseButtonDown(1))
            {
                TypeEventSystem.Global.Send(new EventB()
                {
                });
            }
        }
    }
}