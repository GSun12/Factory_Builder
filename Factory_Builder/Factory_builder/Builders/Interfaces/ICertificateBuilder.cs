using Factory_builder.Models;

namespace Factory_builder.Builders.Interfaces
{
    public interface ICertificateBuilder : IBuilderAbstract<Certificate>
    {
        CertificateBuilder Initialize();
        CertificateBuilder SetName(string name = "Certificate");
        CertificateBuilder SetSize(int size = 12);

    }
}
