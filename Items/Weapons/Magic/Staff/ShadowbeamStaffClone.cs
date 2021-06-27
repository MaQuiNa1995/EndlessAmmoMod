
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Weapons.Magic.Staff
{
	class ShadowbeamStaffClone : ModItem
	{
		//public override string Texture => "items/Item_" + ItemID.ShadowbeamStaff;
		//D:\Users\MaQuiNa1995\Documents\My Games\Terraria\ModLoader\Mod Sources\MaquiMod\Items\Weapons\Magic\Staff\ShadowbeamStaffClone.png
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Varita Lineal");
			Tooltip.SetDefault("Atraviesa con lineas a tus enemigos !!");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ShadowbeamStaff);
			item.color = Color.Purple; // This just tweaks the weapon sprite in inventory, just so we know which ShadowBeam Staff is ours and not vanillas
			item.damage = 8; // Down from 53
		}
	}
}
