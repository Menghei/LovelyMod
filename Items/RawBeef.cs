using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class CookedBeef : ModItem
	{
		//TODO - Make raw beef and add recipe to turn raw into cooked beef
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("You killed a cow to get this.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 50;
			item.useTurn = true; //Not sure what this does...
		}
	}
}
