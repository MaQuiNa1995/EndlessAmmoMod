using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedWoodCreator : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.Wood;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Madera Infinita");
            Tooltip.SetDefault("Esta madera nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Wood);
            item.color = Color.Purple;
            item.maxStack = 1;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood,400);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}