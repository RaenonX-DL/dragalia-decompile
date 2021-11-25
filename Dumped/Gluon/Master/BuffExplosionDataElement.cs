using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuffExplosionDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _HitAttrLabel;

		[SerializeField]
		private float _HitRange;

		[SerializeField]
		private string _EffectName;

		[SerializeField]
		private int _EffectTrigger;

		[SerializeField]
		private string _SeName;

		public int Id => default(int);

		public string HitAttrLabel => null;

		public float HitRange => default(float);

		public string EffectName => null;

		public int EffectTrigger => default(int);

		public string SeName => null;
	}
}
