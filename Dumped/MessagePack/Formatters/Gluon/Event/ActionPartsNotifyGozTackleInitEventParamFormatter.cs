using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ActionPartsNotifyGozTackleInitEventParamFormatter : IMessagePackFormatter<ActionPartsNotifyGozTackleInitEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, ActionPartsNotifyGozTackleInitEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ActionPartsNotifyGozTackleInitEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
