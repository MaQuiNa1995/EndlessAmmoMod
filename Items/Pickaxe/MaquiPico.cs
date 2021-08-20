using Terraria.ID;
using Terraria.ModLoader;

namespace MaQuiMod.Items.Pickaxe
{
    public class MaquiPico : ModItem
    { 
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pico-hacha de Maqui");
            Tooltip.SetDefault("El legendario Pico-Hacha de Maqui");
        }

        public override void SetDefaults()
        {
            item.damage = 0;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 1;
            item.useAnimation = 10;
            item.pick = 200;
            item.axe = 200;
            item.tileBoost = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 0;
            item.value = 1000;
            item.rare = ItemRarityID.Purple;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}