using Terraria;
using Terraria.ModLoader;

namespace x10
{
	public class x10Item : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			item.damage *= 10;
			item.shootSpeed /= 10;
			item.crit *= 10;
			item.useTime /= 10;
			item.velocity *= 10;
			item.axe *= 10;
			item.buffTime *= 10;
			item.defense *= 10;
			item.hammer *= 10;
			item.healLife *= 10;
			item.healMana *= 10;
			item.knockBack *= 10;
			item.lifeRegen *= 10;
			item.mana /= 10;
			item.manaIncrease *= 10;
			item.maxStack *= 10;
			item.pick *= 10;
			item.reuseDelay /= 10;
			item.scale *= 10;
			//item.spawnTime /= 10;
			item.tileBoost *= 10;
			item.value *= 10;
		}
	}
}
