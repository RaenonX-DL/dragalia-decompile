using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenMainStoryMissionStateListFormatter : IMessagePackFormatter<AtgenMainStoryMissionStateList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenMainStoryMissionStateList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenMainStoryMissionStateList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
