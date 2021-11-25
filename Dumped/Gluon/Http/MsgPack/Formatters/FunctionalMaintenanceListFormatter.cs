using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FunctionalMaintenanceListFormatter : IMessagePackFormatter<FunctionalMaintenanceList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FunctionalMaintenanceList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FunctionalMaintenanceList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
