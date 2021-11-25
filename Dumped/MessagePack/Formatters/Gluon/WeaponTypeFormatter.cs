using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class WeaponTypeFormatter : IMessagePackFormatter<WeaponType>
	{
		public int Serialize(ref byte[] bytes, int offset, WeaponType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WeaponType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(WeaponType);
		}
	}
}
