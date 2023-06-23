using QFramework.Architecture;
using QFramework.Rule;

namespace QFramework.Model
{
    public abstract class AbstractModel : IModel
    {
        private IArchitecture mArchitecturel;

        IArchitecture IBelongToArchitecture.GetArchitecture()
        {
            return mArchitecturel;
        }

        void ICanSetArchitecture.SetArchitecture(IArchitecture architecture)
        {
            mArchitecturel = architecture;
        }

        void IModel.Init()
        {
            OnInit();
        }

        protected abstract void OnInit();
    }
}