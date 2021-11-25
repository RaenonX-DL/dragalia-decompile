using System.Collections.Generic;

namespace Gluon
{
	public class CharacterLoadBalancer
	{
		private List<CharacterSelector> _alwaysCharacterSelectors;

		private List<CharacterSelector> _sparseCharacterSelectors;

		public void AddCharacter(CharacterSelector selector, bool isOtherPlayerCharacter)
		{
		}

		public void RemoveCharacter(CharacterSelector selector)
		{
		}

		public void InactivateOtherPlayer(CharacterSelector c)
		{
		}

		public void Update()
		{
		}

		public bool CanExecTask(CharacterBase character)
		{
			return default(bool);
		}

		private bool IsSameCharacter(CharacterSelector selector, CharacterBase chara)
		{
			return default(bool);
		}
	}
}
