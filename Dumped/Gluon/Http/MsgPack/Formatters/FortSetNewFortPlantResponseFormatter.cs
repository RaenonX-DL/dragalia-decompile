using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FortSetNewFortPlantResponseFormatter : IMessagePackFormatter<FortSetNewFortPlantResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FortSetNewFortPlantResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FortSetNewFortPlantResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
