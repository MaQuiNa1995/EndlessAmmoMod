using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Items.Potions
{
    public class MagicManaPotion : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pocion infinita De Mana");
            Tooltip.SetDefault("¿ Cansado de llevar miles y miles de potis de mana en el inventario ?");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 1;                 //this is where you set the max stack of item
            item.width = 20;
            item.height = 28;
            item.value = 100;
            item.rare = 3;
            item.healMana = 400;
            item.consumable = false;           //this make that the item is consumable when used
            item.buffType = mod.BuffType("BorracheraMagica");    //this is where you put your Buff name
            item.buffTime = 2500;    //this is the buff duration        20000 = 6 min
            item.buffTime = 1000;

            return;
        }
    }
}
