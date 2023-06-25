using System;
using QFramework.Architecture;
using QFramework.TypeEvent;
using UnityEngine;

namespace CounterApp.Event
{
    public struct InterfaceEventA
    {
    }

    public struct InterfaceEventB
    {
    }

    public class TypeEventSystemInterfaceExample : MonoBehaviour
        , IOnEvent<InterfaceEventA>
        , IOnEvent<InterfaceEventB>
    {
        private void Start()
        {
            this.RegisterEvent<InterfaceEventA>()
                .UnRegisterWhenGameObjectDestroyed(gameObject);
            this.RegisterEvent<InterfaceEventB>();
        }

        private void OnDestroy()
        {
            this.UnRegisterEvent<InterfaceEventB>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                TypeEventSystem.Global.Send<InterfaceEventA>();
            }

            if (Input.GetMouseButtonDown(1))
            {
                TypeEventSystem.Global.Send<InterfaceEventB>();
            }
        }

        public void OnEvent(InterfaceEventA e)
        {
            Debug.Log("Event Interface: " + e.GetType().Name);
        }

        public void OnEvent(InterfaceEventB e)
        {
            Debug.Log("Event Interface: " + e.GetType().Name);
        }
    }
}