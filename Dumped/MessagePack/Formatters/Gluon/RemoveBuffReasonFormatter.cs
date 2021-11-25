using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class RemoveBuffReasonFormatter : IMessagePackFormatter<RemoveBuffReason>
	{
		public int Serialize(ref byte[] bytes, int offset, RemoveBuffReason value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RemoveBuffReason Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RemoveBuffReason);
		}
	}
}
