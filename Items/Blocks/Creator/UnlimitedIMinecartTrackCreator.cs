using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedIMinecartTrackCreator : ModItem
    {
        public override string Texture => "Terraria/Item_" + ItemID.MinecartTrack;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rail Infinito");
            Tooltip.SetDefault("Este rail de vagoneta nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.MinecartTrack);
            item.color = Color.Purple;
            item.maxStack = 1;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MinecartTrack,500);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}