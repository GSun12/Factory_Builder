using Factory_builder.Builders.Interfaces;
using Factory_builder.Models;

namespace Factory_builder.Builders
{
    public class CertificateBuilder : BuilderAbstract<Certificate>, ICertificateBuilder
    {
        public CertificateBuilder Initialize()
        {
            Prototype= new Certificate();
            return this;
        }
        public CertificateBuilder SetName(string name="Certificate")
        {
            Prototype.Name = name;
            return this;
        }
        public CertificateBuilder SetSize(int size = 12)
        {
            Prototype.Size = size;
            return this;
        }

    }
}
