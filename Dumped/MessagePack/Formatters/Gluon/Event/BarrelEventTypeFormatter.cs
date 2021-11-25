using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BarrelEventTypeFormatter : IMessagePackFormatter<BarrelBombDungeonObject.BarrelEventType>
	{
		public int Serialize(ref byte[] bytes, int offset, BarrelBombDungeonObject.BarrelEventType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BarrelBombDungeonObject.BarrelEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BarrelBombDungeonObject.BarrelEventType);
		}
	}
}
