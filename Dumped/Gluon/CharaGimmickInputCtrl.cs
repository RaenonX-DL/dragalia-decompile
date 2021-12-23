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

		private Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> inputUIDict;

		private Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> reserveDragonInputUIDict;

		private Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dynamicSkillInputUIDict;

		public void Attach(CharacterBase chara)
		{
		}

		public void AttachReserveDragon(CharacterSelector selector)
		{
		}

		public void AttachDynamicSkill(CharacterBase chara, List<int> skillIdList)
		{
		}

		private void AddActionId(ref List<int> list, int actionId)
		{
		}

		private void Attach(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara)
		{
		}

		private void Attach(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara, int actionId)
		{
		}

		private bool IsRegistered(CharacterBase chara, int actionId)
		{
			return default(bool);
		}

		private bool IsRegistered(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara, int actionId)
		{
			return default(bool);
		}

		public void Show(CharacterBase chara)
		{
		}

		private void Show(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara)
		{
		}

		public void Hide(CharacterBase chara, bool anim)
		{
		}

		private void Hide(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara, bool anim)
		{
		}

		public void Hide(bool anim)
		{
		}

		private void Hide(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, bool anim)
		{
		}

		public bool IsVisible(CharacterBase chara)
		{
			return default(bool);
		}

		private bool IsVisible(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara)
		{
			return default(bool);
		}

		public void SetCount(CharacterBase chara, int num, bool force = false, bool immediate = false)
		{
		}

		private void SetCount(ref Dictionary<CharacterBase, Dictionary<int, CharaGimmickBaseInputUI>> dict, CharacterBase chara, int num, bool force = false, bool immediate = false)
		{
		}

		private int GetCurrentActionId(CharacterBase chara)
		{
			return default(int);
		}
	}
}
