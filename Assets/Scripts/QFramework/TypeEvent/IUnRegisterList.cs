using System;
using System.Collections.Generic;
using UnityEngine;

namespace QFramework.TypeEvent
{
    public interface IUnRegisterList
    {
        List<IUnRegister> UnregisterList { get; }
    }
}