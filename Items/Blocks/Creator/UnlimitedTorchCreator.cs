using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedTorchCreator : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.Torch; 

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Antorcha Infinita");
            Tooltip.SetDefault("Esta antorcha nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Torch);
            item.color = Color.Purple;
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Torch,500);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}