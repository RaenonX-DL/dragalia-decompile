using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class GameStepEvent : EventBase<GameStepEvent>
	{
		public enum StepTypes
		{
			None,
			BRRequestInitWorld,
			BRCompleteInitWorld,
			JoinBeginPartySwitch,
			JoinChangeCharacter
		}

		[Key(1)]
		public StepTypes step;
	}
}
