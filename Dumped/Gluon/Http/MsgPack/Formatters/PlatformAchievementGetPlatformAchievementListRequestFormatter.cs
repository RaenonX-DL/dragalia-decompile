using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class PlatformAchievementGetPlatformAchievementListRequestFormatter : IMessagePackFormatter<PlatformAchievementGetPlatformAchievementListRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, PlatformAchievementGetPlatformAchievementListRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public PlatformAchievementGetPlatformAchievementListRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
