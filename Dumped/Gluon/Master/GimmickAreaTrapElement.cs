using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickAreaTrapElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _CommonActionHitAttr;

		[SerializeField]
		private int _Attack;

		[SerializeField]
		private int _RateDamage;

		[SerializeField]
		private float _HitTime;

		[SerializeField]
		private float _CoolTime;

		[SerializeField]
		private float _MarkerSize;

		[SerializeField]
		private float _TrapHitSize;

		public string Id => null;

		public string CommonActionHitAttr => null;

		public int Attack => default(int);

		public int RateDamage => default(int);

		public float HitTime => default(float);

		public float CoolTime => default(float);

		public float MarkerSize => default(float);

		public float TrapHitSize => default(float);
	}
}
