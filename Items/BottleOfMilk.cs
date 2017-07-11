using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class BottleOfMilk : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("How delectable!");
		}

		public override void SetDefaults()
		{
			item.healLife = 50;
			item.consumable = true;
			item.useStyle = 2; //Drinking animation
			item.useTime = 10;
			item.useAnimation = 10;
			item.width = 12;
			item.height = 12;
			item.maxStack = 50;
			item.useTurn = true; //Not sure what this does...
			//TODO - Add a buff on use
		}
	}
}
