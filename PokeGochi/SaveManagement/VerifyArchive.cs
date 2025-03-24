using PokeGochi.Pokemon;

namespace PokeGochi.SaveManagement
{
    internal class VerifyArchive
    {
        private static readonly string tamagochiSave = "tamagochiSave.txt";

        public static PokemonObject ReadSave()
        {
            if (File.Exists(tamagochiSave)) {
                string[] content = File.ReadAllLines(tamagochiSave);
                var pO = new PokemonObject(content[0], int.Parse(content[1]), new List<FlavorText>() { new FlavorText(content[2]) });
                return pO;
            }

            return null;
        }

        public static void WriteSave(PokemonObject pO)
        {
            string[] content = { pO.Name, pO.Id.ToString(), pO.flavorText };
            File.WriteAllLines(tamagochiSave, content);
        }

    }
}
