using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaquiMod.Npc.Hostile.Inferno
{
    public class XcisionMage : ModNPC
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Xcision el mago");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.RuneWizard];
        }

        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.DarkCaster);
        }

        public override void AI()
        {
            npc.TargetClosest(true);

            float counter = npc.ai[0]++;

            if (counter >= 80f)
            {
                float Speed = 12f;
                Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2) + 40, npc.position.Y + (npc.height / 2));
                int damage = 30;
                int type = mod.ProjectileType("PlanetaHostil");
                Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 17);
                float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
                int num54 = Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0f, 0);
                npc.frameCounter = 1;
                npc.ai[0] = 0;
                counter = 0;
                npc.frameCounter = 0;
            }

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return 0;
        }

    }
}
