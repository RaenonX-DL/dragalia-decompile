using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeStrengthSkillElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _StrengthSkillGroupId;

		[SerializeField]
		private int _SkillId;

		public int Id => default(int);

		public int StrengthSkillGroupId => default(int);

		public int SkillId => default(int);
	}
}
