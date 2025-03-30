using PokeGochi.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokeGochi.Model
{
    internal class Mascot
    {
        private string[] frases = { "Sinto que estou ficando mais forte! Obrigado pelo cuidado!", "Uau! Estou brilhando! Acho que algo está mudando em mim...", "Você é o melhor treinador de todos! Vamos juntos para mais aventuras!", "Brrrr... Está frio aqui! Acho que preciso de um lugar quentinho...", "Eu me sinto sozinho... Você pode ficar mais um pouco comigo?", "Estou cheio de energia! Vamos correr e saltar por aí!", "Esse carinho é tão bom... Obrigado por cuidar de mim!" };

        public Mascot(PokemonObject pokemon, string ownerName = " ", string nickName = " ", int happiness = 10, int feeded = 10)
        {
            Pokemon = pokemon;
            OwnerName = ownerName;
            NickName = nickName;

            felicidade = happiness;
            alimentacao = feeded;
        }

        private PokemonObject Pokemon { get; }
        private string NickName { get; set; }
        private string OwnerName { get; }

        private int felicidade;

        private string currentName => NickName == " " ? OwnerName : NickName;

        public int Felicidade
        {
            get { return felicidade; }
        }


        private int alimentacao;

        public int Alimentacao
        {
            get { return alimentacao; }
        }

        public void AlimentarPokemon()
        {
            if (Alimentacao > 0 && Alimentacao < 10)
            {
                alimentacao += 2;
                felicidade--;

                Console.WriteLine($"{currentName} comeu até não conseguir mais");
            }
            else if (Alimentacao >= 10)
            {
                alimentacao = 10;
                Console.WriteLine($"{currentName} já está de buxin chei!");
                felicidade--;
            }
        }

        public void BrincarPokemon()
        {
            if (Felicidade > 0 && Felicidade < 10)
            {
                alimentacao--;
                felicidade += 2;

                Console.WriteLine($"{currentName} está se divertindo muito com você!");
            }
            else if (Felicidade >= 10)
            {
                felicidade = 10;
                Console.WriteLine($"{currentName} está cansado de brincar...");
                alimentacao--;
            }
        }

        public void ConversarPokemon()
        {
            string choice = frases[Random.Shared.Next(0, frases.Length - 1)];

            felicidade--;
            alimentacao--;

            Console.WriteLine(choice);
        }

        public void VerificarPokemon()
        {
            Console.WriteLine($"--- Observar Pokemon ---\n" +
                $"{currentName} : {Pokemon.Name}\n"+
                $"Dono: {OwnerName}.\n" +
                $"Alimentado: {(Alimentacao > 5 ? "Satisfeito" : "Faminto")}.\n" +
                $"Humor: {(Felicidade > 5 ? "Feliz" : "Tedio")}.");
        }

        public string[] mascotData()
        {
            string[] content = { Pokemon.Name, OwnerName, NickName, Felicidade.ToString(), Alimentacao.ToString() };
            return content;
        }

    }
}
