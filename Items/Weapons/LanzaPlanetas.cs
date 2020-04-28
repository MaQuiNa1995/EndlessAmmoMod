using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Items.Weapons
{
    public class LanzaPlanetas : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lanzador De Planetas");
            Tooltip.SetDefault("Lanza planetas a tus enemigos !!");
        }

        public override void SetDefaults()
        {
            item.damage = 80;
            item.crit = 19;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 3;
            item.mana = 20;             //mana use
            item.UseSound = SoundID.Item20;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Planeta");  //this make the item shoot your projectile
            item.shootSpeed = 15f;    //projectile speed when shoot
        }
    }
}