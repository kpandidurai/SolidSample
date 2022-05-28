using System.IO;

namespace ArdalisRating
{
    public class ReadFilePolicySource
    {
        public ReadFilePolicySource()
        {
        }

        public string ReadPolicy()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
