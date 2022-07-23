namespace APIEnem.Models.Candidato
{
    public class Sexo
    {
        private char RepresentaçãoSexo { get; set; }
        private string SexoReal { get; set; }

        public Sexo(char Alfanumérico)
        {
            if (char.ToUpper(Alfanumérico) != 'F' && char.ToUpper(Alfanumérico) != 'M')
            {
                throw new Exception("O alfanumérico inserido não é valido.");
            }

            if (char.ToUpper(Alfanumérico) == 'F')
            {
                this.SexoReal = "Feminino";
            }
            else
            {
                this.SexoReal = "Masculino";
            }

            this.RepresentaçãoSexo = Alfanumérico;
        }

        public char CódigoSexo()
        {
            return RepresentaçãoSexo;
        }

        public string GetSexo()
        {
            return SexoReal;
        }
    }
}
