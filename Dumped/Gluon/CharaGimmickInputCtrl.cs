using System.Collections.Generic;

namespace Gluon
{
	public class CharaGimmickInputCtrl
	{
		public enum InputUIType
		{
			None,
			AddCountInput,
			AddGaugeInput
		}

		private Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> _inputUIDic;

		public void Attach(CharacterBase chara)
		{
		}

		private bool IsRegistered(CharacterBase owner, int actionId)
		{
			return default(bool);
		}

		public void Show(CharacterBase owner)
		{
		}

		public void Hide(CharacterBase owner, bool anim)
		{
		}

		public void Hide(bool anim)
		{
		}

		public bool IsVisible(CharacterBase owner)
		{
			return default(bool);
		}

		public void SetCount(CharacterBase owner, int num, bool force = false, bool immediate = false)
		{
		}

		private int GetCurrentActionId(CharacterBase chara)
		{
			return default(int);
		}
	}
}
