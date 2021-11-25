using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityLimitedGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _IsEffectMix;

		[SerializeField]
		private float _MaxLimitedValue;

		[SerializeField]
		private string _AbilityLimitedText;

		public int Id => default(int);

		public int IsEffectMix => default(int);

		public float MaxLimitedValue => default(float);

		public string AbilityLimitedText => null;
	}
}
