using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class SkillPointFormatter : IMessagePackFormatter<SkillPoint>
	{
		public int Serialize(ref byte[] bytes, int offset, SkillPoint value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SkillPoint Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
