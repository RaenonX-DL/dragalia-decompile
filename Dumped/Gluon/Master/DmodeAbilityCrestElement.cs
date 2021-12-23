using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeAbilityCrestElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AbilityCrestId;

		[SerializeField]
		private int _StrengthParamGroupId;

		[SerializeField]
		private int _StrengthAbilityGroupId;

		public int Id => default(int);

		public int AbilityCrestId => default(int);

		public int StrengthParamGroupId => default(int);

		public int StrengthAbilityGroupId => default(int);
	}
}
