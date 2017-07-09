using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class ModdedGrenade : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			//Makes grenades count as ammo
			if(item.type == ItemID.Grenade)
			{
				item.ammo = ItemID.Grenade;
			}
		}
	}
}