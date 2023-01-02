using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ReLogic.Graphics;
using Terraria.GameContent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace JourneyRecipes.Particle
{
    public class NetDiagnosticsUI : INetDiagnosticsUI
    {
        private struct CounterForMessage
        {
            public int timesReceived;

            public int timesSent;

            public int bytesReceived;

            public int bytesSent;

            public bool exemptFromBadScoreTest;

            public void Reset()
            {
                timesReceived = 0;
                timesSent = 0;
                bytesReceived = 0;
                bytesSent = 0;
            }

            public void CountReadMessage(int messageLength)
            {
                timesReceived++;
                bytesReceived += messageLength;
            }

            public void CountSentMessage(int messageLength)
            {
                timesSent++;
                bytesSent += messageLength;
            }
        }

        private CounterForMessage[] _counterByMessageId = new CounterForMessage[150];

        private Dictionary<int, CounterForMessage> _counterByModuleId = new Dictionary<int, CounterForMessage>();

        private int _highestFoundReadBytes = 1;

        private int _highestFoundReadCount = 1;

        public void Reset()
        {
            for (int i = 0; i < _counterByMessageId.Length; i++)
            {
                _counterByMessageId[i].Reset();
            }
            _counterByModuleId.Clear();
            _counterByMessageId[10].exemptFromBadScoreTest = true;
            _counterByMessageId[82].exemptFromBadScoreTest = true;
        }

        public void CountReadMessage(int messageId, int messageLength)
        {
            _counterByMessageId[messageId].CountReadMessage(messageLength);
        }

        public void CountSentMessage(int messageId, int messageLength)
        {
            _counterByMessageId[messageId].CountSentMessage(messageLength);
        }

        public void CountReadModuleMessage(int moduleMessageId, int messageLength)
        {
            _counterByModuleId.TryGetValue(moduleMessageId, out var value);
            value.CountReadMessage(messageLength);
            _counterByModuleId[moduleMessageId] = value;
        }

        public void CountSentModuleMessage(int moduleMessageId, int messageLength)
        {
            _counterByModuleId.TryGetValue(moduleMessageId, out var value);
            value.CountSentMessage(messageLength);
            _counterByModuleId[moduleMessageId] = value;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
