using Rocket.API;

namespace Sadusko.KickAfterDeath
{
   public class Configuration : IRocketPluginConfiguration
    {
       public bool KickAndBan;
       public string kickmessage;
       public string kickandbanmessage;
       public uint bantime;
       public void LoadDefaults()
           
       {
           KickAndBan = false;
           kickmessage = "You have been kicked because you died!";
           kickandbanmessage = "You have been kicked and banned because you died!";
           bantime = 84600;
           
       }
    }
}
