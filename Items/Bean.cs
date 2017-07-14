using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class Bean : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Lovely!");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true; //Not sure what this does...
		}
	}
}
