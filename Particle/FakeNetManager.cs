using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.Net;

namespace JourneyRecipes.Particle
{
    public class FakeNetManager
    {
	public static readonly FakeNetManager Instance = new FakeNetManager();
	private Dictionary<ushort, NetModule> _modules = new Dictionary<ushort, NetModule>();
        public void SendToServerAndSelf(NetPacket packet)
        {
            if (Main.netMode == 1)
            {
                NetManager.Instance.SendToServer(packet);
                SendToSelf(packet);
                
            }
            else if (Main.netMode == 0)
            {
                SendToSelf(packet);
            }
        }
        public void SendToSelf(NetPacket packet)
        {
            packet.Reader.BaseStream.Position = 3L;
            Read(packet.Reader, Main.myPlayer, packet.Length);
            NetManager.SendCallback(packet);
            JourneyRecipes.ActiveNetDiagnosticsUI.CountSentModuleMessage(packet.Id, packet.Length);
        }
        public void Read(BinaryReader reader, int userId, int readLength)
        {
            ushort num = reader.ReadUInt16();
            if (_modules.ContainsKey(num))
            {
                _modules[num].Deserialize(reader, userId);
            }
            JourneyRecipes.ActiveNetDiagnosticsUI.CountReadModuleMessage(num, readLength);
        }
    }
}
