using Terraria;
using Terraria.ModLoader;

namespace x10
{
	public class x10NPC : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{
			npc.damage *= 10;
			npc.defense *= 10;
			npc.lifeMax *= 10;
			npc.life *= 10;
			npc.breath *= 10;
			npc.defDamage *= 10;
			npc.defDefense *= 10;
			npc.extraValue *= 10;
			npc.friendlyRegen *= 10;
			npc.knockBackResist *= 10;
			npc.lifeRegen *= 10;
			npc.realLife *= 10;
			npc.scale *= 10;
			npc.stepSpeed *= 10;
			npc.takenDamageMultiplier *= 10;
			npc.teleportTime /= 10;
			npc.timeLeft *= 10;
			npc.value *= 10;
			npc.velocity *= 10;
		}
	}
}