using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionBulletParameterFormatter : IMessagePackFormatter<RunActionBulletParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionBulletParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionBulletParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
