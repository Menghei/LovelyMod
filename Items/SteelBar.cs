using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class SteelBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tough stuff.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true; //Not sure what this does...
		}

		public override void AddRecipes()
		//TODO - Change recipe to use coal and iron
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RaethentiteOre");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
