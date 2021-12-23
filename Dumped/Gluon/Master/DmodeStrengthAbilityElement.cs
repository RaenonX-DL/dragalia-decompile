using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeStrengthAbilityElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _StrengthAbilityGroupId;

		[SerializeField]
		private int _AbilityId;

		public int Id => default(int);

		public int StrengthAbilityGroupId => default(int);

		public int AbilityId => default(int);
	}
}
