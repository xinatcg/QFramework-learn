using QFrameworkUml.TypeEvent;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameworkUml.BindableProperty
{
    public interface IReadonlyBindableProperty<T>
    {
        T Value { get; }

        IUnRegister RegisterWithInitValue(Action<T> action);
        void UnRegister(Action<T> onValueChanged);
        IUnRegister Register(Action<T> onValueChanged);
    }

}