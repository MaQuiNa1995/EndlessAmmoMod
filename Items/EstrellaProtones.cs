using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Items
{
	public class EstrellaProtones : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Estrella De Protones");
			Tooltip.SetDefault("Municion de tipo estrella caida");
		}

		public override void SetDefaults()
		{
			item.ranged = true;
			item.maxStack = 1;
			item.consumable = false;
			item.knockBack = -1.5f;
			item.value = 5;
			item.rare = 3;
			item.shoot = mod.ProjectileType("FallenStar");
			item.shootSpeed = 1f;
			item.ammo = AmmoID.FallenStar;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			// recipe.AddTile(TileID.CrystalBall);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
