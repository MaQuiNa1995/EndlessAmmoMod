using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Items.Blocks.Creator
{
    public class UnlimitedWoodWallCreator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pared de Madera Infinita");
            Tooltip.SetDefault("Esta pared de madera nunca se acaba !!!");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = false;
            item.createWall = 4;
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