﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Core;
using Rocket.Unturned;
using Rocket.Core.Plugins;
using SDG.Unturned;
using SDG;

namespace KickAfterDeath
{
    public class KickOrBanAfterDeath : RocketPlugin<Configuration>
    {
        KickOrBanAfterDeath Instance;
        protected override void Load()
        {
            Instance = this;
            Rocket.Unturned.Events.UnturnedPlayerEvents.OnPlayerDeath += UnturnedPlayerEvents_OnPlayerDeath;

            Rocket.Core.Logging.Logger.Log("This plugin was made by Sadusko ^^");
            if (this.Configuration.Instance.KickAndBan)
            {
                Rocket.Core.Logging.Logger.LogWarning("Kick and Ban is enabled, the player will be kicked and banned after death!");

            }
            if (this.Configuration.Instance.KickAndBan == false)
            {
                Rocket.Core.Logging.Logger.LogWarning("Kick and Ban is disabled, the player will be kicked only after death!");

            }
        }

        void UnturnedPlayerEvents_OnPlayerDeath(Rocket.Unturned.Player.UnturnedPlayer player, SDG.Unturned.EDeathCause cause, SDG.Unturned.ELimb limb, Steamworks.CSteamID murderer)
        {
            if (this.Configuration.Instance.KickAndBan)
            {
                player.Ban(this.Configuration.Instance.kickandbanmessage, 86400);

            }
            if (this.Configuration.Instance.KickAndBan == false)
            {
                player.Kick(this.Configuration.Instance.kickmessage);

            }
        }
    }
}
