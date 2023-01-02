using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.NetModules;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Net;

namespace JourneyRecipes.Particle
{
    public class ParticleOrchestrator
    {
        private static ParticlePool<GasParticle> _poolGas = new ParticlePool<GasParticle>(200, GetNewGasParticle);
        private static ParticlePool<PrettySparkleParticle> _poolPrettySparkle = new ParticlePool<PrettySparkleParticle>(200, GetNewPrettySparkleParticle);


        private static GasParticle GetNewGasParticle()
        {
            return new GasParticle();
        }
        private static PrettySparkleParticle GetNewPrettySparkleParticle()
        {
            return new PrettySparkleParticle();
        }


        private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
        {
            float num = 30f;
            float num2 = 0f;
            for (float num3 = 0f; num3 < 4f; num3 += 1f)
            {
                PrettySparkleParticle prettySparkleParticle = _poolPrettySparkle.RequestParticle();
                Vector2 vector = ((float)Math.PI / 2f * num3 + num2).ToRotationVector2() * 4f;
                prettySparkleParticle.ColorTint = new Color(0.9f, 0.85f, 0.4f, 0.5f);
                prettySparkleParticle.LocalPosition = settings.PositionInWorld;
                prettySparkleParticle.Rotation = vector.ToRotation();
                prettySparkleParticle.Scale = new Vector2((num3 % 2f == 0f) ? 2f : 4f, 0.5f) * 1.1f;
                prettySparkleParticle.FadeInNormalizedTime = 5E-06f;
                prettySparkleParticle.FadeOutNormalizedTime = 0.95f;
                prettySparkleParticle.TimeToLive = num;
                prettySparkleParticle.FadeOutEnd = num;
                prettySparkleParticle.FadeInEnd = num / 2f;
                prettySparkleParticle.FadeOutStart = num / 2f;
                prettySparkleParticle.AdditiveAmount = 0.35f;
                prettySparkleParticle.Velocity = -vector * 0.2f;
                prettySparkleParticle.DrawVerticalAxis = false;
                if (num3 % 2f == 1f)
                {
                    prettySparkleParticle.Scale *= 1.5f;
                    prettySparkleParticle.Velocity *= 1.5f;
                }
                JourneyRecipes.ParticleSystem_World_OverPlayers.Add(prettySparkleParticle);
            }
            for (float num4 = 0f; num4 < 4f; num4 += 1f)
            {
                PrettySparkleParticle prettySparkleParticle2 = _poolPrettySparkle.RequestParticle();
                Vector2 vector2 = ((float)Math.PI / 2f * num4 + num2).ToRotationVector2() * 4f;
                prettySparkleParticle2.ColorTint = new Color(1f, 1f, 0.2f, 1f);
                prettySparkleParticle2.LocalPosition = settings.PositionInWorld;
                prettySparkleParticle2.Rotation = vector2.ToRotation();
                prettySparkleParticle2.Scale = new Vector2((num4 % 2f == 0f) ? 2f : 4f, 0.5f) * 0.7f;
                prettySparkleParticle2.FadeInNormalizedTime = 5E-06f;
                prettySparkleParticle2.FadeOutNormalizedTime = 0.95f;
                prettySparkleParticle2.TimeToLive = num;
                prettySparkleParticle2.FadeOutEnd = num;
                prettySparkleParticle2.FadeInEnd = num / 2f;
                prettySparkleParticle2.FadeOutStart = num / 2f;
                prettySparkleParticle2.Velocity = vector2 * 0.2f;
                prettySparkleParticle2.DrawVerticalAxis = false;
                if (num4 % 2f == 1f)
                {
                    prettySparkleParticle2.Scale *= 1.5f;
                    prettySparkleParticle2.Velocity *= 1.5f;
                }
                JourneyRecipes.ParticleSystem_World_OverPlayers.Add(prettySparkleParticle2);
                for (int i = 0; i < 1; i++)
                {
                    Dust dust = Dust.NewDustPerfect(settings.PositionInWorld, 169, vector2.RotatedBy(Main.rand.NextFloatDirection() * ((float)Math.PI * 2f) * 0.025f) * Main.rand.NextFloat());
                    dust.noGravity = true;
                    dust.scale = 1.4f;
                    Dust dust2 = Dust.NewDustPerfect(settings.PositionInWorld, 169, -vector2.RotatedBy(Main.rand.NextFloatDirection() * ((float)Math.PI * 2f) * 0.025f) * Main.rand.NextFloat());
                    dust2.noGravity = true;
                    dust2.scale = 1.4f;
                }
            }
        }

        public static void SpawnParticlesDirect(ParticleOrchestraType type, ParticleOrchestraSettings settings)
        {
            if (Main.netMode != 2)
            {
                switch (type)
                {
                    case ParticleOrchestraType.Excalibur:
                        Spawn_Excalibur(settings);
                        break;
                }
            }
        }
        public static void RequestParticleSpawn(bool clientOnly, ParticleOrchestraType type, ParticleOrchestraSettings settings, int? overrideInvokingPlayerIndex = null)
        {
            settings.IndexOfPlayerWhoInvokedThis = (byte)Main.myPlayer;
            if (overrideInvokingPlayerIndex.HasValue)
            {
                settings.IndexOfPlayerWhoInvokedThis = (byte)overrideInvokingPlayerIndex.Value;
            }
            if (clientOnly)
            {
                SpawnParticlesDirect(type, settings);
            }
            else
            {
                //NetManager.Instance.SendToServer(NetParticlesModule.Serialize(type, settings));
                FakeNetManager.Instance.SendToServerAndSelf(NetParticlesModule.Serialize(type, settings));
                SpawnParticlesDirect(type, settings);
            }
        }
    }
}
