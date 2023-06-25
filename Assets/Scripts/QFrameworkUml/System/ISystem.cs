using QFrameworkUml.Rule;

namespace QFrameworkUml.System
{
    public interface ISystem : IBelongToArchitecture, ICanSetArchitecture, ICanGetModel, ICanGetUtility,
        ICanRegisterEvent, ICanSendEvent, ICanGetSystem
    {
        void Init();
    }

}