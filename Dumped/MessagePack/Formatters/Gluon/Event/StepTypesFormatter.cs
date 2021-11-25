using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class StepTypesFormatter : IMessagePackFormatter<GameStepEvent.StepTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, GameStepEvent.StepTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GameStepEvent.StepTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(GameStepEvent.StepTypes);
		}
	}
}
