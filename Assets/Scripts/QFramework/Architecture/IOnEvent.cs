namespace QFramework.Architecture
{
    public interface IOnEvent<T>
    {
        void OnEvent(T e);
    }

}