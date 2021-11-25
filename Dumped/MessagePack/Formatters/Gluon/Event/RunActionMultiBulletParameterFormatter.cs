using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionMultiBulletParameterFormatter : IMessagePackFormatter<RunActionMultiBulletParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionMultiBulletParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionMultiBulletParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
