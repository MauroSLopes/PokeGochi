using PokeGochi.Pokemon;

namespace PokeGochi.Controller.SaveManagement
{
    internal class VerifyArchive
    {
        private static readonly string tamagochiSave = "tamagochiSave.txt";

        public static PokemonObject ReadSave()
        {
            if (File.Exists(tamagochiSave))
            {
                string[] content = File.ReadAllLines(tamagochiSave);
                var pO = new PokemonObject(content[0], content[1], int.Parse(content[2]), new List<FlavorText>() { new FlavorText(content[3]) });
                return pO;
            }

            return null;
        }

        public static void WriteSave(PokemonObject pO)
        {
            string[] content = { pO.Owner, pO.Name, pO.Id.ToString(), pO.flavorText };
            File.WriteAllLines(tamagochiSave, content);
        }

    }
}
