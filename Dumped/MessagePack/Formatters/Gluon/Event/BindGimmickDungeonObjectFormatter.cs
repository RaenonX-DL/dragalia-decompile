using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BindGimmickDungeonObjectFormatter : IMessagePackFormatter<BindGimmickDungeonObject>
	{
		public int Serialize(ref byte[] bytes, int offset, BindGimmickDungeonObject value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BindGimmickDungeonObject Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
