using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class ApplePie : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("How delectable!");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 50;
			item.useTurn = true; //Not sure what this does...
			//TODO - Make consumable and add a buff
		}

		public override void AddRecipes()
		{
			//TODO - Add proper recipes
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}
