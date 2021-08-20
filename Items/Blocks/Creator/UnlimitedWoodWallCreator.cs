using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedWoodWallCreator : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.WoodWall;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pared de Madera Infinita");
            Tooltip.SetDefault("Esta pared de madera nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodWall); 
            item.color = Color.Purple;
            item.maxStack = 1;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodWall,400);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}