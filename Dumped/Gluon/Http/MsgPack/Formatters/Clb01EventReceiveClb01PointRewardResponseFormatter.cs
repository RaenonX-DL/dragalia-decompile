using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class Clb01EventReceiveClb01PointRewardResponseFormatter : IMessagePackFormatter<Clb01EventReceiveClb01PointRewardResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, Clb01EventReceiveClb01PointRewardResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Clb01EventReceiveClb01PointRewardResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
