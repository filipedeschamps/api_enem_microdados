using APIEnem.Models.Interfaces;

namespace APIEnem.Models.Candidato
{
    public class TiposDeFaixaEtária : IModelFaixaEtaria
    {
        Dictionary<string, string> _FaixaEtáriaTipos = new Dictionary<string, string>();
        
        public TiposDeFaixaEtária()
        {
            _FaixaEtáriaTipos.Add(new FaixaEtária("1").ToString(), "Menor de 17 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("2").ToString(), "17 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("3").ToString(), "18 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("4").ToString(), "19 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("5").ToString(), "20 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("6").ToString(), "21 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("7").ToString(), "22 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("8").ToString(), "23 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("9").ToString(), "24 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("10").ToString(), "25 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("11").ToString(), "Entre 26 e 30 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("12").ToString(), "Entre 31 e 35 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("13").ToString(), "Entre 36 e 40 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("14").ToString(), "Entre 41 e 45 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("15").ToString(), "Entre 46 e 50 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("16").ToString(), "Entre 51 e 55 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("17").ToString(), "Entre 56 e 60 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("18").ToString(), "Entre 61 e 65 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("19").ToString(), "Entre 65 e 70 anos");
            _FaixaEtáriaTipos.Add(new FaixaEtária("20").ToString(), "Maior de 70 anos");
        }

        public string RetornarTipoDaFaixaEtária(FaixaEtária FaixaEtária)
        {
            string? Retorno;
            if (_FaixaEtáriaTipos.TryGetValue(FaixaEtária.ToString(), out Retorno) is true)
            {
                return Retorno;
            }
            else
            {
                throw new Exception("Não foi possível encontrar o tipo da faixa etária com esse valor!");
            }
        }
    }
}
