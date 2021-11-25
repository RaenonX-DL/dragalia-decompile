using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class GoToIngameInfo_BRInitDataFormatter : IMessagePackFormatter<GoToIngameInfo.BRInitData>
	{
		public int Serialize(ref byte[] bytes, int offset, GoToIngameInfo.BRInitData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GoToIngameInfo.BRInitData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
