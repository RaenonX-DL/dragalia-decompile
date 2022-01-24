using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class ChainCtrl
	{
		private static readonly AbilityTargetAction[] AllTargetActions;

		public float _timer;

		private float _validTime;

		private Dictionary<AbilityTargetAction, int> _chainNumDic;

		private PlayerCharacter _owner;

		public bool isPause
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private PlayerCharacter currentOwner => null;

		public int prevValForCheck
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AbilityTargetAction checkingTargetAction
		{
			[CompilerGenerated]
			get
			{
				return default(AbilityTargetAction);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ChainCtrl(PlayerCharacter owner)
		{
		}

		public int GetChainNum(AbilityTargetAction targetAction = AbilityTargetAction.NONE)
		{
			return default(int);
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public void Add(int actionId, int skillId, int num = 1, bool isIgnoreTransform = false)
		{
		}

		private void Add(AbilityTargetAction targetAction, int num, int actionId)
		{
		}
	}
}
