using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PruebaConsola
{
    public class Class1
    {
        private string path;
        private List<string> listaProductos;
        private List<string> listaProductosSerializada;
        public Class1()
        {
            this.listaProductos = new List<string>();
            this.path = @".\sdf";
        }

        public void god()
        {
            this.path = @".\MOCK_DATA.json";
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), this.path);

            if (File.Exists(fullPath))
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string json_str = sr.ReadToEnd();
                    listaAux = System.Text.Json.JsonSerializer.Deserialize<List<Datos>>(json_str);
                }
            }
        }
    }
}
