using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    // Definição da classe Carro
    internal class Carro
    {
        // propriedade da classe carro

        public string Marca { get; set; } // publica a propriedade da marca
        //Propriedade privada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } // privad, acessivel apenas dentro da classe
        // propriedade privada com um campo privado e um método getter e setter personalizados 
        private int ano; //campo privado
    
            public int Ano
        {
            get { return ano; } //Getter, para acessar o valor do campo privado
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) //Verificação para garantir um valor válido
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }
        //método público para exibir informações do carro

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"Ano: {ano}");

        }
        // método para calcular a idade do carro
        public int Calcularidade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }
        //método para definir o modelo do carro (com exemplo de uso de propriedade privada)

        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; //Acessando a propriedade privada dentro da classe
        }
    }

    internal class program
    {
        static void Main(string[]args)
        {
            //Criando um novo objeto da classe carro
            Carro meuCarro = new Carro();

            //atribuindo valores ás propriedades públicas e privadas 
            meuCarro.Marca = "Toyota";
            meuCarro.DefinirModelo("Corola"); // usando metodo para definir modelo, pois é privado
            meuCarro.Ano = 2020; //Apropriedade Ano é pública, mas com uma validação interna 

            //exibindo informações do carro 
            meuCarro.ExibirInformacoes();

            //Calculando e exibindo a idade do carro
            int idadeCarro = meuCarro.Calcularidade();
            Console.WriteLine($"Idade do Carro: {idadeCarro} anos");

            //Mantendo o console aberto
            Console.ReadLine();



        }
    }

}
