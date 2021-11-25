using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionGameMasterEventFormatter : IMessagePackFormatter<RunActionGameMasterEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionGameMasterEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionGameMasterEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
