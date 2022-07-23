using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class TiposDeEstadoCivil : IModelEstadoCivil
    {
        Dictionary<int, string> _tiposEstadoCivil = new Dictionary<int, string>();
        
        public TiposDeEstadoCivil()
        {
            _tiposEstadoCivil.Add(0, "Não informado");
            _tiposEstadoCivil.Add(1, "Solteiro(a)");
            _tiposEstadoCivil.Add(2, "Casado(a)/Mora com companheiro(a)");
            _tiposEstadoCivil.Add(3, "Divorciado(a)/Desquitado(a)/Separado(a)");
            _tiposEstadoCivil.Add(4, "Viúvo(a)");
        }

        public string CONVERTER_CÓDIGO_CIVIL_PARA_TEXTO(int CÓDIGO_ESTADO_CIVIL)
        {
            string Retorno = "";
            if (_tiposEstadoCivil.TryGetValue(CÓDIGO_ESTADO_CIVIL, out Retorno) is true)
            {
                return Retorno;
            }
            else
            {
                throw new Exception("Não foi possível encontrar o tipo de estado civil com esse código!");
            }
        }
    }
}
