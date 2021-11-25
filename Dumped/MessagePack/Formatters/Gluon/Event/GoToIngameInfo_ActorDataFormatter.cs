using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class GoToIngameInfo_ActorDataFormatter : IMessagePackFormatter<GoToIngameInfo.ActorData>
	{
		public int Serialize(ref byte[] bytes, int offset, GoToIngameInfo.ActorData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GoToIngameInfo.ActorData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
