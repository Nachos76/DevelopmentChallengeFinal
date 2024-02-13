using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Idioma
    {
        private readonly Dictionary<string, string> _diccionario = new Dictionary<String, String>();
        private readonly string _defaultLang = "en-EN";
        public Idioma(string langid)
        {
            _diccionario = CargarDiccionario(langid);
        }

        private Dictionary<string, string> CargarDiccionario(string langId)
        {
            string diccPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Traducciones", langId + ".json");
            string defaultDiccPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Traducciones", _defaultLang + ".json");
            try
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(diccPath));
            }
            catch (Exception)
            {
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(defaultDiccPath));
            }
        }

        public string Traducir(string clave)
        {
            try {              
                string texto = _diccionario[clave];
                return texto;
            }
            catch (Exception)
            { 
                return clave + "*";
            }

        }

        public string Traducir(string clave, int cant)
        {
            try
            {
                string texto;
                if (cant > 1)
                    texto = _diccionario[clave + "_PLURAL"];
                else
                    texto = _diccionario[clave];

                return texto;
            }

            catch (Exception)
            {
                return clave + "*";
            }
}
    }
}
