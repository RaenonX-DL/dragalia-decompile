using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugAutoJoinRoomSettingFormatter : IMessagePackFormatter<DebugAutoJoinRoomSetting>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugAutoJoinRoomSetting value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugAutoJoinRoomSetting Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
