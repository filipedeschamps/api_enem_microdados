namespace APIEnem.Models.Candidato
{
    public class NúmeroInscrição
    {
        private string Número { get; set; }

        public NúmeroInscrição(string NúmeroDeInscrição)
        {
            if (NúmeroDeInscrição.Length != 12)
            {
                throw new Exception("O número de inscrição tem que ter exatamente 12 caracteres.");
            }

            foreach (char Letra in NúmeroDeInscrição)
            {
                if (char.IsDigit(Letra) is false)
                {
                    throw new Exception("O número de inscrição só pode conter dígitos.");
                }
            }

            this.Número = NúmeroDeInscrição;
        }

        public override string ToString()
        {
            return Número;
        }
    }
}