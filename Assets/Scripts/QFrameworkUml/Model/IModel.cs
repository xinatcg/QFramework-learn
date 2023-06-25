using QFrameworkUml.Rule;

namespace QFrameworkUml.Model
{
    public interface IModel : IBelongToArchitecture, ICanSetArchitecture, ICanGetUtility, ICanSendEvent
    {
        void Init();
    }

}