namespace Lista_de_Objetos.classes
{
    public class Produto
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        
        public Produto(){}
        public Produto(int codigo, string nome, float preco){
            Code = codigo;
            Name = nome;
            Price = preco;
        }
    }
}