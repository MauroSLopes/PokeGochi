using PokeGochi.Controller.CreatePokemon;
using PokeGochi.Model;
using PokeGochi.Pokemon;

namespace PokeGochi.Controller.SaveManagement
{
    internal class VerifyArchive
    {
        private static readonly string tamagochiSave = "tamagochiSave.txt";

        public static Mascot ReadSave()
        {
            try {
                
                string[] content = File.ReadAllLines(tamagochiSave);

                Mascot pokemon = new Mascot(ApiRequest.GetPokemon(content[0]), content[1], content[2], int.Parse(content[3]), int.Parse(content[4]));
                return pokemon;

            } catch (Exception ex)
            {
                return null;
            }

        }

        public static void WriteSave(Mascot pokemon)
        {
            File.WriteAllLines(tamagochiSave, pokemon.mascotData());
        }

    }
}
