using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SkillChainDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _ActivateCondition;

		[SerializeField]
		private int _ConditionArgs1;

		public int Id => default(int);

		public int GroupId => default(int);

		public int ActivateCondition => default(int);

		public int ConditionArgs1 => default(int);
	}
}
