using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace JourneyRecipes.Particle
{
    public interface IParticle
    {
        bool ShouldBeRemovedFromRenderer { get; }

        void Update(ref ParticleRendererSettings settings);

        void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
    }
    public struct ParticleRendererSettings
    {
        public Vector2 AnchorPosition;
    }
    public interface IPooledParticle : IParticle
    {
        bool IsRestingInPool { get; }

        void RestInPool();

        void FetchFromPool();
    }
}
