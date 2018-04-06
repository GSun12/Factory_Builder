using Factory_builder.Builders.Interfaces;

namespace Factory_builder.Builders
{
    public class BuilderAbstract<T> : IBuilderAbstract<T> where T : class
    {
        protected T Prototype { get; set; }

        public T GetProduct()
        {
            return Prototype;
        }

        public void SetPrototype(T prototype)
        {
            Prototype = prototype;
        }
    }
}
