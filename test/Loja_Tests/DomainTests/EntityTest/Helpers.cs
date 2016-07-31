using System.Reflection;

namespace Loja_Tests.DomainTests.EntityTest
{
    public class Helpers
    {
        private readonly object _entity;

        public Helpers()
        {
        }

        public Helpers(object entity)
        {
            _entity = entity;
        }

        public PropertyInfo GetInfoDaPropriedade(string nome)
        {
            return _entity.GetType().GetProperty(nome);
        }

        public string GetNomeDoTipoDaPropriedade(string nomePropriedade)
        {
            return _entity.GetType().GetProperty(nomePropriedade).PropertyType.FullName;
        }

        public object GetValorDaPropriedade(object objeto, string propriedade)
        {
            return objeto.GetType().GetProperty(propriedade).GetValue(_entity);
        }
    }
}