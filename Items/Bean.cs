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

			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 10;
			item.useAnimation = 10;
		}

    public override bool UseItem(Player player)
    {
      Main.dayTime = false;
      Main.time = 16200.0;
			return true;
    }
	}
}
