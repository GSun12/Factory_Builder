using Factory_builder.Models;

namespace Factory_builder.Builders.Interfaces
{
    public interface IContractBuilder : IBuilderAbstract<Contract>
    {
        ContractBuilder Initialize();
        ContractBuilder SetName(string name = "Contract");
        ContractBuilder SetSize(int size = 24);
    }
}
