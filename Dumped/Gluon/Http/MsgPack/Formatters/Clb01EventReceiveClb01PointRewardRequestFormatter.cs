using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class Clb01EventReceiveClb01PointRewardRequestFormatter : IMessagePackFormatter<Clb01EventReceiveClb01PointRewardRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, Clb01EventReceiveClb01PointRewardRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Clb01EventReceiveClb01PointRewardRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
