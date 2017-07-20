using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class GunmetalBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Make guns!");
		}
		//TODO - Test that Arms Dealer sells this item

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true; //Not sure what this does...
		}
	}
}
