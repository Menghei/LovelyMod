using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items.Accessories
{
	public class Scope : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Allows greater gun accuracy.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.value = 100000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			//TODO - Figure out how to increase damage with only guns
			player.rangedDamage*=1.2f;
		}

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}