
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Npc.Hostile.Overworld
{
    public class MecanicEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ojito mecanico");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[0];
        }

        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.DemonEye);

            npc.width = 32;
            npc.height = 32;
            npc.damage = 45;
            npc.defense = 10;
            npc.lifeMax = 200;

            npc.knockBackResist = 0.75F;

            npc.aiStyle = 62;
            aiType = NPCID.EyeofCthulhu;

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (Main.hardMode == true) ? SpawnCondition.OverworldNightMonster.Chance * 0.1f : 0f;
        }

    }
}
