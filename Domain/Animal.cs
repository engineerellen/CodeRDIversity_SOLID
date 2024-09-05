namespace Domain
{
    public class Animal
    {
        public int ID { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public string Raça { get; set; } = string.Empty;


        public virtual string EmitirSom() => "";
    }
}