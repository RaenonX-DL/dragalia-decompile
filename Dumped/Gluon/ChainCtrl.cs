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

		public int GetChainNum(AbilityTargetAction targetAction = AbilityTargetAction.NONE)
		{
			return default(int);
		}

		public void Update(PlayerCharacter owner)
		{
		}

		public void Reset()
		{
		}

		public void Add(PlayerCharacter owner, int actionId, int skillId, int num = 1, bool isIgnoreTransform = false)
		{
		}

		private void Add(AbilityTargetAction targetAction, int num = 1)
		{
		}
	}
}
