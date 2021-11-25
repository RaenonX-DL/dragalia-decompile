using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ActionGrantElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _DurationSec;

		[SerializeField]
		private AbilityTargetAction _TargetAction;

		[SerializeField]
		private int _GrantCondition;

		[SerializeField]
		private int _Attribute;

		public int Id => default(int);

		public float DurationSec => default(float);

		public AbilityTargetAction TargetAction => default(AbilityTargetAction);

		public int GrantCondition => default(int);

		public int Attribute => default(int);
	}
}
