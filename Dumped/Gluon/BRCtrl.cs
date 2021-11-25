using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class BRCtrl : MonoBehaviour
	{
		private Dictionary<int, int> enemyDict;

		private Stack<CharacterBase> deadCharas;

		private bool isGameEnd;

		private bool bgmChanged;

		private float elapsedSec;

		public CharacterBase targetingPlayerBotForTutorial;

		private BRAiChecker brAiChecker;

		public CharacterBase winnerChara
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsGameEnd => default(bool);

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void RegisterPlayerDeadEvent()
		{
		}

		public void RegisterEnemyDeadEvent()
		{
		}

		public void RegisterEnemyEntryEvent()
		{
		}

		public bool CanEnterBush(CharacterBase chara)
		{
			return default(bool);
		}

		private BattleRoyalEnemyElement GetBREnemyElem(EnemyCharacter enemy)
		{
			return null;
		}

		public bool CheckQuestClear()
		{
			return default(bool);
		}

		public void SetGameEndParam(CharacterBase winner, CharacterBase lastDead)
		{
		}

		public void CreateEffectPool()
		{
		}

		public void PrepareWin(List<CharacterBase> winCharas)
		{
		}
	}
}
