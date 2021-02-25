/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRCtrl : MonoBehaviour
	{
		// Fields
		private Dictionary<int, int> enemyDict;
		private Stack<CharacterBase> deadCharas;
		[CompilerGenerated]
		private CharacterBase _winnerChara_k__BackingField;
		private bool isGameEnd;
		private bool bgmChanged;
		private float elapsedSec;
		public CharacterBase targetingPlayerBotForTutorial;
		private BRAiChecker brAiChecker;
	
		// Properties
		public CharacterBase winnerChara { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsGameEnd { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public HumanCharacter human;
			public BRCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _RegisterPlayerDeadEvent_b__0(CharacterBase from);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public EnemyManage.EnemyInfo enemy;
			public BRCtrl __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _RegisterEnemyDeadEvent_b__0(CharacterBase from);
			internal void _RegisterEnemyDeadEvent_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public EnemyManage.EnemyInfo enemy;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RegisterEnemyEntryEvent_b__0();
		}
	
		// Constructors
		public BRCtrl();
	
		// Methods
		private void Start();
		private void Update();
		public void RegisterPlayerDeadEvent();
		public void RegisterEnemyDeadEvent();
		public void RegisterEnemyEntryEvent();
		public bool CanEnterBush(CharacterBase chara);
		private BattleRoyalEnemyElement GetBREnemyElem(EnemyCharacter enemy);
		public bool CheckQuestClear();
		public void SetGameEndParam(CharacterBase winner, CharacterBase lastDead);
		public void CreateEffectPool();
		public void PrepareWin(List<CharacterBase> winCharas);
	}
}
