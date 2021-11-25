using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class TransSkillFormatter : IMessagePackFormatter<TransSkill>
	{
		public int Serialize(ref byte[] bytes, int offset, TransSkill value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TransSkill Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
