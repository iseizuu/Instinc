using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instincsharp.config
{
    internal class Reader
    {
        public string token { get; set; }
        public string prefix { get; set; }
        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONreader data = JsonConvert.DeserializeObject<JSONreader>(json);

                this.token = data.token;
                this.prefix = data.prefix;
            }
        }
    }
    internal sealed class JSONreader
    {
        public string token { get; set; }
        public string prefix { get; set; }
    }

}
