using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace x10
{
	public class x10Player : ModPlayer
	{
		public override void ResetEffects()
		{
			player.statLifeMax2 *= 10;
		}

		public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath)
		{
			Player player = new Player();
			player.statLife *= 10;
		}
	}
}
