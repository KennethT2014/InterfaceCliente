using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CapData
{
    public class FileJSON
    {
        public List<Client> Clients = new List<Client>();
        public string _path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Client.json";
        public void addClient(Client client)
        {
            this.Clients.Add(client);
        }

        public Client FindClient(int index)
        {
           return Clients.Where(x => x.Id-1 == index).First();
        }

        public void SerializerClient()
        {
            string clienteJSON = JsonConvert.SerializeObject(Clients, Formatting.Indented);
            File.WriteAllText(_path, clienteJSON);
        }

        public void DeserealizeClient()
        {
            if (File.Exists(_path))
            {
                string stringJSON;
                using (var reader = new StreamReader(_path))
                {
                    stringJSON = reader.ReadToEnd();
                }

                //this.Clients.AddRange(JsonConvert.DeserializeObject<List<Client>>(stringJSON));

                Clients = JsonConvert.DeserializeObject<List<Client>>(stringJSON);
            }
            else
            {
                this.Clients.Clear();
            }
        }
    }
}
