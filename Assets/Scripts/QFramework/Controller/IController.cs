using QFramework.Rule;

namespace QFramework.Controller
{
    public interface IController : IBelongToArchitecture, ICanSendCommand, ICanGetSystem, ICanGetModel,
        ICanRegisterEvent, ICanSendQuery, ICanGetUtility
    {
    }
}