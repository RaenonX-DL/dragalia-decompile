using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeDungeonThemeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ThemeGroupId;

		[SerializeField]
		private int _PlusLevelMin;

		[SerializeField]
		private int _PlusLevelMax;

		[SerializeField]
		private float _FailedTermsTimeElapsed;

		[SerializeField]
		private int _ShowPopupAndPause;

		[SerializeField]
		private int _SkillPowerReduction;

		[SerializeField]
		private int _AreaChangeCondition;

		[SerializeField]
		private int _BossAppear;

		[SerializeField]
		private int _ThemeBgmGroupId;

		[SerializeField]
		private int _HasSpeedLimit;

		public int Id => default(int);

		public int ThemeGroupId => default(int);

		public int PlusLevelMin => default(int);

		public int PlusLevelMax => default(int);

		public float FailedTermsTimeElapsed => default(float);

		public int ShowPopupAndPause => default(int);

		public int SkillPowerReduction => default(int);

		public int AreaChangeCondition => default(int);

		public int BossAppear => default(int);

		public int ThemeBgmGroupId => default(int);

		public int HasSpeedLimit => default(int);
	}
}
