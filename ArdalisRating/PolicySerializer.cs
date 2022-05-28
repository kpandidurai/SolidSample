using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public PolicySerializer()
        {
        }

        public Policy GetPolicy(string policyString)
        {
            // if we keep chaging the type of serialization , we can create a fractory method.
            return JsonConvert.DeserializeObject<Policy>(policyString,
                new StringEnumConverter());
        }
    }
}
