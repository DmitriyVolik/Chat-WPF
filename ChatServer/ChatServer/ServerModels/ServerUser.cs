using System.Net.Sockets;
using System.Text.Json.Serialization;

namespace ChatServer.ServerModels
{
    public class ServerUser
    {
        [JsonIgnore] 
        public Socket ns { get; set; }
        
        public string Login { get; set; }
        
        public bool IsSignIn { get; set; }
    }
}