using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class CookedBeef : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("How delectable!");
		}

		public override void SetDefaults()
		{
			item.healLife = 50;
			item.consumable = true;
			item.useStyle = 2;
			item.useTime = 10;
			item.useAnimation = 10;
			item.width = 12;
			item.height = 12;
			item.maxStack = 50;
			item.useTurn = true; //Not sure what this does...
			//TODO - Make consumable and add a buff
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RawBeef", 1);
			//TODO - Require a nearby campfire to cook this
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
