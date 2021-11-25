using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BulletSyncMoveEventParamFormatter : IMessagePackFormatter<BulletSyncMoveEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BulletSyncMoveEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BulletSyncMoveEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
