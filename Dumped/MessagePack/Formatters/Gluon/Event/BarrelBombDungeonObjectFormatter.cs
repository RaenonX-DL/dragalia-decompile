using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BarrelBombDungeonObjectFormatter : IMessagePackFormatter<BarrelBombDungeonObject>
	{
		public int Serialize(ref byte[] bytes, int offset, BarrelBombDungeonObject value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BarrelBombDungeonObject Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
