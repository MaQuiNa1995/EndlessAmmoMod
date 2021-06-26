using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedIMinecartTrackCreator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rail Infinito");
            Tooltip.SetDefault("Este rail de vagoneta nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 4;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = false;
            item.createTile = TileID.MinecartTrack;
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