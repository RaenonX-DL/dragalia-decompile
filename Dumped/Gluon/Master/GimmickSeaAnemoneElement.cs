using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickSeaAnemoneElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _BubbleEffect;

		[SerializeField]
		private float _SensingRange;

		[SerializeField]
		private float _FinishSensingRange;

		[SerializeField]
		private string _ActionHitAttribute;

		[SerializeField]
		private float _Attack;

		[SerializeField]
		private int _RateDamage;

		[SerializeField]
		private float _BubbleSpeed;

		[SerializeField]
		private float _BubbleMaxRange;

		[SerializeField]
		private float _BubbleIntervalSec;

		[SerializeField]
		private float _BubbleSize;

		[SerializeField]
		private float _BubbleHeight;

		[SerializeField]
		private float _BubbleHitSize;

		public string Id => null;

		public string BubbleEffect => null;

		public float SensingRange => default(float);

		public float FinishSensingRange => default(float);

		public string ActionHitAttribute => null;

		public float Attack => default(float);

		public int RateDamage => default(int);

		public float BubbleSpeed => default(float);

		public float BubbleMaxRange => default(float);

		public float BubbleIntervalSec => default(float);

		public float BubbleSize => default(float);

		public float BubbleHeight => default(float);

		public float BubbleHitSize => default(float);
	}
}
