namespace Factory_builder.Factory.Interface
{
    public interface IAbstractFactory<T, TEnum> where T: class
    {
        T Generate(TEnum productType);
        
    }
}
