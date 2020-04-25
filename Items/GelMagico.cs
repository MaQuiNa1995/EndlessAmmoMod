using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Items
{
	public class GelMagico : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Magico");
			Tooltip.SetDefault("Municion de tipo gel infinito");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = -1;
			item.height = 1;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = -1.5f;
			item.value = 5;
			item.rare = 2;
			item.shoot = mod.ProjectileType("Gel");
			item.shootSpeed = 0.01f;
			item.ammo = AmmoID.Gel;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
