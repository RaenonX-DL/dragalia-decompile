using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class GoToIngameInfoFormatter : IMessagePackFormatter<GoToIngameInfo>
	{
		public int Serialize(ref byte[] bytes, int offset, GoToIngameInfo value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GoToIngameInfo Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
