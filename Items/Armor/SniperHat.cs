using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SniperHat : ModItem
	{
		public override void SetDefaults()
		{
			//TODO - Add proper equip effect
			item.width = 22;
			item.height = 14;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			//TODO - Add proper recipes
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}