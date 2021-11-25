using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class FireSpecialBulletFormatter : IMessagePackFormatter<FireSpecialBullet>
	{
		public int Serialize(ref byte[] bytes, int offset, FireSpecialBullet value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FireSpecialBullet Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
