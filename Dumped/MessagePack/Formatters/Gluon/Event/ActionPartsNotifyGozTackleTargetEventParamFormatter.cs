using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ActionPartsNotifyGozTackleTargetEventParamFormatter : IMessagePackFormatter<ActionPartsNotifyGozTackleTargetEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, ActionPartsNotifyGozTackleTargetEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ActionPartsNotifyGozTackleTargetEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
