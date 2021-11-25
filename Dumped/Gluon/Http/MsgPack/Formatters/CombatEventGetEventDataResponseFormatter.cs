using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CombatEventGetEventDataResponseFormatter : IMessagePackFormatter<CombatEventGetEventDataResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CombatEventGetEventDataResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CombatEventGetEventDataResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
