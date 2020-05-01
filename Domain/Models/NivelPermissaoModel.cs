namespace Domain.Models
{
   public class NivelPermissaoModel
    {
        public NivelPermissaoModel() { }
        public NivelPermissaoModel(int pId)
        {
            Id = pId;
        }
        public int Id { get; set; }
        public string NomePermissao { get; set; }
    }
}
