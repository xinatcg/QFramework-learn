using System;
using CounterApp;
using QFramework.Architecture;
using QFramework.Controller;
using QFramework.Rule;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

namespace Editor
{
    public class EditorCounterApp : EditorWindow, IController
    {
        [MenuItem(("CounterApp/Window"))]
        public static void Open()
        {
            GetWindow<EditorCounterApp>().Show();
        }

        private CounterAppModel mCounterAppModel;

        private void OnEnable()
        {
            mCounterAppModel = this.GetModel<CounterAppModel>();
        }

        private void OnDisable()
        {
            mCounterAppModel = null;
        }

        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                this.SendCommand<IncreaseCountCommand>();
            }

            GUILayout.Label(mCounterAppModel.Count.Value.ToString());


            if (GUILayout.Button("-"))
            {
                this.SendCommand<DecreaseCountCommand>();
            }
        }

        public IArchitecture GetArchitecture()
        {
            return CounterApp.CounterApp.Interface;
        }
    }
}