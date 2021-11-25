using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ReasonRemoveActorFormatter : IMessagePackFormatter<ReasonRemoveActor>
	{
		public int Serialize(ref byte[] bytes, int offset, ReasonRemoveActor value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ReasonRemoveActor Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
