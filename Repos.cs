using System.Text.Json;

namespace Joao_Ramos_DR2_TP2
{
    static class Repos
    {
        public static List<Produto> Load(string path)
        {
            string p = Path.GetFullPath($"./{path}");

            try
            {
                string text = File.ReadAllText(p);
                return JsonSerializer.Deserialize<List<Produto>>(text);
            }
            catch(FileNotFoundException) {
                var stream = File.Create(p.ToString());
                stream.Close();

                return JsonSerializer.Deserialize<List<Produto>>("[]");
            }
        }

        public static async void Save(List<Produto> produtoList, string path)
        {
            string text = JsonSerializer.Serialize(produtoList);
            File.WriteAllText(path, text);
        }


    }
}
