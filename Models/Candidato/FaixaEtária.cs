namespace APIEnem.Models.Candidato
{
    public class FaixaEtária
    {
        public string Valor { get; set; }
        
        public FaixaEtária(string CódigoDeFaixa)
        {
            if (CódigoDeFaixa.Length != 1 && CódigoDeFaixa.Length != 2)
            {
                throw new Exception("Código de faixa não condiz com o esperado");
            }

            foreach (char Letra in CódigoDeFaixa)
            {
                if (char.IsDigit(Letra) is false)
                {
                    throw new Exception("O Código de faixa etária só pode conter dígitos");
                }
            }

            this.Valor = CódigoDeFaixa;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
