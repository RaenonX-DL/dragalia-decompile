using System.Collections.Generic;

namespace Gluon
{
	public class CharacterTriggerCtrl
	{
		private List<CharacterBuffTriggerReactionBase> _reactions;

		public void RegisterReaction(CharacterBuffTriggerReactionBase reaction)
		{
		}

		public void UnregisterReaction(CharacterBuffTriggerReactionBase reaction)
		{
		}

		public void Update()
		{
		}

		public void OnAppendBuff(ref CharacterAppendBuffTrigger trigger)
		{
		}

		public void OnRemoveBuff(ref CharacterRemoveBuffTrigger trigger)
		{
		}
	}
}
