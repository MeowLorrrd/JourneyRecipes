using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyRecipes.Particle
{
    public class EmptyDiagnosticsUI : INetDiagnosticsUI
    {
        public void Reset()
        {
        }

        public void CountReadMessage(int messageId, int messageLength)
        {
        }

        public void CountSentMessage(int messageId, int messageLength)
        {
        }

        public void CountReadModuleMessage(int moduleMessageId, int messageLength)
        {
        }

        public void CountSentModuleMessage(int moduleMessageId, int messageLength)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }

}
