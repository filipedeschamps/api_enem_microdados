using System;
using System.Data;
using Newtonsoft.Json;

namespace APIEnem.Models.Candidato
{
    public class Json
    {
        private string JSON_RETORNO { get; set; }

        public Json(DataTable Data)
        {
            this.JSON_RETORNO = JsonConvert.SerializeObject(Data);
        }

        public override string ToString()
        {
            return JSON_RETORNO.ToString();
        }
    }
}
