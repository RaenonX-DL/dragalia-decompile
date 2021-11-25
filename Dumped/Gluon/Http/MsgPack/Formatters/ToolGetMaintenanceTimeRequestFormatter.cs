using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ToolGetMaintenanceTimeRequestFormatter : IMessagePackFormatter<ToolGetMaintenanceTimeRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ToolGetMaintenanceTimeRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ToolGetMaintenanceTimeRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
