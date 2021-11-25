using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BindGimmickEventTypeFormatter : IMessagePackFormatter<BindGimmickDungeonObject.BindGimmickEventType>
	{
		public int Serialize(ref byte[] bytes, int offset, BindGimmickDungeonObject.BindGimmickEventType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BindGimmickDungeonObject.BindGimmickEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BindGimmickDungeonObject.BindGimmickEventType);
		}
	}
}
