using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Npc.Hostile.Overworld
{
    public class MaQuiZombie : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Raquel la zombie");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; // Main.npcFrameCount[3];
        }

        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Zombie);

            npc.damage = 20;
            npc.defense = 10;
            npc.lifeMax = 100;

            npc.aiStyle = 3;
            aiType = NPCID.Zombie;
            animationType = NPCID.Zombie;

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {

            return SpawnCondition.OverworldNightMonster.Chance * 0.05f;
        }

    }
}
