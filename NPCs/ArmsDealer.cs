using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.NPCs
{
	public class ModdedArmsDealer : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			switch(type)
			{
				case NPCID.ArmsDealer:
					shop.item[nextSlot].SetDefaults(mod.ItemType("GunmetalBar"));
					nextSlot++;
					break;
			}
		}
	}
}
