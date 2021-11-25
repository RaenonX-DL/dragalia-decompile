using System.Collections.Generic;

namespace Gluon
{
	public class MainGameRebornCtrl
	{
		private class SystemRebornParam
		{
			public float rebornTimer;

			public int consumeRebornCount;

			public bool isRebornCountDown;
		}

		private class AbilityRebornParam
		{
			public float rebornTimer;

			public int usedRebornCount;

			public int rebornCountLimit;

			public bool isReserved;

			public bool isRebornCountDown;

			public float hpRate;

			public float consumeDpRate;
		}

		private SystemRebornParam _systemRebornParam;

		private Dictionary<CharacterSelector, AbilityRebornParam> _abilityRebornParamDic;

		private InGameUICtrl uiCtrl;

		private CharacterManager charaManager;

		private GameDataManager gameDataManager;

		private InGameSettings settings;

		public MainGameRebornCtrl(GameDataManager gameDataManager, InGameSettings settings, CharacterManager charaManager, InGameUICtrl uiCtrl)
		{
		}

		public void OnContinue()
		{
		}

		public bool IsAbilityRebornQuest()
		{
			return default(bool);
		}

		public void RegisterAbilityRebornParam(CharacterSelector owner, int rebornCount, float hpRate, float consumeDpRate)
		{
		}

		public void Update()
		{
		}

		public bool UpdateAllDead()
		{
			return default(bool);
		}

		private bool UpdateSystemReborn()
		{
			return default(bool);
		}

		private void UpdateAbilityRebornAll()
		{
		}

		private void UpdateAbilityReborn(CharacterSelector selector, AbilityRebornParam param)
		{
		}

		public bool IsRemainAnyRebornCount()
		{
			return default(bool);
		}

		public bool IsAbilityRebornCountingDown()
		{
			return default(bool);
		}

		private List<CharacterBase> GetSystemRebornTargetCharas()
		{
			return null;
		}

		public bool CanAnyReborn(CharacterBase chara)
		{
			return default(bool);
		}

		public bool CanSystemReborn(CharacterBase chara)
		{
			return default(bool);
		}

		public bool CanAbilityReborn(CharacterBase chara)
		{
			return default(bool);
		}

		public int GetAnyRebornCount(CharacterBase chara)
		{
			return default(int);
		}

		public int GetSystemRebornCount(CharacterBase chara)
		{
			return default(int);
		}

		public int GetAbilityRebornCount(CharacterBase chara)
		{
			return default(int);
		}

		public void StartAbilityReborn(CharacterBase chara)
		{
		}

		private float GetCurrentDpRate()
		{
			return default(float);
		}

		private void CancelReborn()
		{
		}
	}
}
