using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugRaidSettingFormatter : IMessagePackFormatter<DebugRaidSetting>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugRaidSetting value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugRaidSetting Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
