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
	
	public class ModdedStickyGrenade : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			//Makes grenades count as ammo
			if(item.type == ItemID.StickyGrenade)
			{
				item.ammo = ItemID.Grenade;
			}
		}
	}
	
	public class ModdedBouncyGrenade : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			//Makes grenades count as ammo
			if(item.type == ItemID.BouncyGrenade)
			{
				item.ammo = ItemID.Grenade;
			}
		}
	}
	
	public class ModdedBeenade : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			//Makes grenades count as ammo
			if(item.type == ItemID.Beenade)
			{
				item.ammo = ItemID.Grenade;
			}
		}
	}
}