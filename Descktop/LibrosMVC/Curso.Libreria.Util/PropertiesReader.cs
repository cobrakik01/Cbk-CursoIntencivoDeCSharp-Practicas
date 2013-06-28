using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Libreria.Util
{
    public class PropertiesReader
    {
        private System.IO.StreamReader streamReader;
        private SortedList<string, string> properties;

        public PropertiesReader(System.IO.StreamReader streamReader)
        {
            this.streamReader = streamReader;
            properties = Load();
        }

        private SortedList<string, string> Load()
        {
            SortedList<string, string> p = new SortedList<string, string>();
            string line = "";
            while ((line = this.streamReader.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    line = line.Trim();
                    if (line.ToCharArray().Length <= 0 || line.ToCharArray()[0] == '#')
                    {
                        continue;
                    }

                    string[] token = line.Split('=');
                    if (token.Length >= 2)
                    {
                        p.Add(token[0].Trim(), token[1].Trim());
                    }
                    else if (token.Length == 1)
                    {
                        p.Add(token[0].Trim(), "");
                    }
                }
            }
            return p;
        }

        public string GetPropertie(string propertie)
        {
            string propertieValue = "";
            if (this.properties.Keys.Contains(propertie))
            {
                propertieValue = this.properties[propertie];
            }
            else
            {
                throw new Exception("No se encontro la propiedad: " + propertie);
            }
            return propertieValue;
        }
    }
}
