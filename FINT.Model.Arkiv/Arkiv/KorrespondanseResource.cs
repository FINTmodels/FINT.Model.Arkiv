// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class KorrespondanseResource 
    {

    
        public KorrespondanseResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
            

        public void AddKorrespondansepart(Link link)
        {
            AddLink("korrespondansepart", link);
        }

        public void AddKorrespondanseparttype(Link link)
        {
            AddLink("korrespondanseparttype", link);
        }
    }
}
