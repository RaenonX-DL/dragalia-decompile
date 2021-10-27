/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainGameRebornCtrl
	{
		// Fields
		private SystemRebornParam _systemRebornParam;
		private Dictionary<CharacterSelector, AbilityRebornParam> _abilityRebornParamDic;
		private InGameUICtrl uiCtrl;
		private CharacterManager charaManager;
		private GameDataManager gameDataManager;
		private InGameSettings settings;
	
		// Nested types
		private class SystemRebornParam
		{
			// Fields
			public float rebornTimer;
			public int consumeRebornCount;
			public bool isRebornCountDown;
	
			// Constructors
			public SystemRebornParam();
		}
	
		private class AbilityRebornParam
		{
			// Fields
			public float rebornTimer;
			public int usedRebornCount;
			public int rebornCountLimit;
			public bool isReserved;
			public bool isRebornCountDown;
			public float hpRate;
			public float consumeDpRate;
	
			// Constructors
			public AbilityRebornParam();
		}
	
		// Constructors
		public MainGameRebornCtrl(GameDataManager gameDataManager, InGameSettings settings, CharacterManager charaManager, InGameUICtrl uiCtrl);
	
		// Methods
		public void OnContinue();
		public bool IsAbilityRebornQuest();
		public void RegisterAbilityRebornParam(CharacterSelector owner, int rebornCount, float hpRate, float consumeDpRate);
		public void Update();
		public bool UpdateAllDead();
		private bool UpdateSystemReborn();
		private void UpdateAbilityRebornAll();
		private void UpdateAbilityReborn(CharacterSelector selector, AbilityRebornParam param);
		public bool IsRemainAnyRebornCount();
		public bool IsAbilityRebornCountingDown();
		private List<CharacterBase> GetSystemRebornTargetCharas();
		public bool CanAnyReborn(CharacterBase chara);
		public bool CanSystemReborn(CharacterBase chara);
		public bool CanAbilityReborn(CharacterBase chara);
		public int GetAnyRebornCount(CharacterBase chara);
		public int GetSystemRebornCount(CharacterBase chara);
		public int GetAbilityRebornCount(CharacterBase chara);
		public void StartAbilityReborn(CharacterBase chara);
		private float GetCurrentDpRate();
		private void CancelReborn();
	}
}
