using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class Apple : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A nice cryspy apple.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 50;
			item.useTurn = true; //Not sure what this does...
			//TODO - Make consumable and add a healing effect
		}

		public override void AddRecipes()
		{
			//TODO - Make apple tree drop this so no recipes will be required
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}