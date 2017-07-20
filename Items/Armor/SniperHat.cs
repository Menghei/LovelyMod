using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SniperHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases ranged damage by 25%");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 14;
			item.rare = 1;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage *= 1.25f;
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
