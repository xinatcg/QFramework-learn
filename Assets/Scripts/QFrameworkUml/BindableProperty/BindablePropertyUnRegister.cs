using QFrameworkUml.TypeEvent;
using System;
using System.Collections.Generic;
using QFrameworkUml.BindableProperty;
using UnityEngine;

namespace QFrameworkUml.BindableProperty
{
    public class BindablePropertyUnRegister<T> : IUnRegister
    {
        public BindableProperty<T> BindableProperty { get; set; }

        public Action<T> OnValueChanged { get; set; }

        public void UnRegister()
        {
            BindableProperty.UnRegister(OnValueChanged);

            BindableProperty = null;
            OnValueChanged = null;
        }
    }
}