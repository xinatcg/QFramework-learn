using QFramework.EasyEvent;
using QFramework.TypeEvent;
using UnityEngine;

namespace CounterApp.Event
{
    public class EasyEventExample: MonoBehaviour
    {
        private EasyEvent mOnMouseLeftClickEvent = new EasyEvent();

        private EasyEvent<int> mOnValueChanged = new EasyEvent<int>();

        public class EventA : EasyEvent<int,int> { }

        private EventA mEventA = new EventA();

        private void Start()
        {
            mOnMouseLeftClickEvent.Register(() =>
            {
                Debug.Log("Easy Event: Mouse left click");
            }).UnRegisterWhenGameObjectDestroyed(gameObject);

            mOnValueChanged.Register(value =>
            {

                Debug.Log($"Easy Event: value change:{value}");
            }).UnRegisterWhenGameObjectDestroyed(gameObject);


            mEventA.Register((a, b) =>
            {
                Debug.Log($"Easy Event: custom event:{a} {b}");
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                mOnMouseLeftClickEvent.Trigger();
            }

            if (Input.GetMouseButtonDown(1))
            {
                mOnValueChanged.Trigger(10);
            }

            // Mouse middle click
            if (Input.GetMouseButtonDown(2))
            {
                mEventA.Trigger(1,2);
            }
        }
    }
}