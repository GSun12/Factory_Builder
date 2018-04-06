namespace Factory_builder.Builders.Interfaces
{
    public interface IBuilderAbstract<T> where T : class
    {
        T GetProduct();

    }
}
