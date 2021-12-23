using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeStrengthParamElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _StrengthParamGroupId;

		[SerializeField]
		private int _Scarcity;

		[SerializeField]
		private int _Hp;

		[SerializeField]
		private int _Atk;

		public int Id => default(int);

		public int StrengthParamGroupId => default(int);

		public int Scarcity => default(int);

		public int Hp => default(int);

		public int Atk => default(int);
	}
}
