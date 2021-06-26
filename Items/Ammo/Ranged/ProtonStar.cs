using IL.Terraria.GameContent.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria.ID;
using Terraria.ModLoader;

namespace MaQuiMod.Items.Ammo.Ranged
{
	public class ProtonStar : ModItem
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
			item.rare = ItemRarityID.Orange;
			item.shoot = mod.ProjectileType("FallenStar");
			item.shootSpeed = 1f;
			item.ammo = AmmoID.FallenStar;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 999);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
