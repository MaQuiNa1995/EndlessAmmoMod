using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstMod.Buffs
{
    public class BorracheraMagica : ModBuff
    {
        private float magicDamageReduction = 0.25f;

        public override void SetDefaults()
        {
            DisplayName.SetDefault("Borrachera De Mana");
            Description.SetDefault("Te sientes emborrachado por todo el mana que te has zampado...\nTu ataque magico se reduce");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            
        }

        // TODO 
        public override bool ReApply(Player player, int time, int buffIndex)
        {

            player.statMana += 400;

            if (magicDamageReduction < 0.50f)
            {
                magicDamageReduction += 0.05f;
            }

            player.magicDamage -= magicDamageReduction;

            return false;
        }

        public override void Update(Player player, ref int buffIndex)
        {

            int buff = mod.BuffType("BorracheraMagica");

            if (!player.HasBuff(buff))
            {
                player.statMana += 400;
            }

            player.AddBuff(BuffID.ManaSickness, 1);  //this is an example of how to add existing buff
            player.magicDamage -= magicDamageReduction;
        }
    }
}
