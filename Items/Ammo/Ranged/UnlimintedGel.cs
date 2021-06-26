
using Terraria.ID;
using Terraria.ModLoader;

namespace MaQuiMod.Items.Ammo.Ranged
{
	public class UnlimintedGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Magico");
			Tooltip.SetDefault("Munición gel infinita");
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
			recipe.AddIngredient(ItemID.Gel, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
