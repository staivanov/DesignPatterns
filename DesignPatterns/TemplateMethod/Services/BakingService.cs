namespace TemplateMethod.Services
{
    public abstract class BakingServiceBase<T> where T : BakedFood, new()
    {
        protected abstract void Bake();
        protected abstract void AddSauce();
        protected abstract void PrepareSwamp();
        //Hook
        protected virtual void Cover() { }
    }
}
