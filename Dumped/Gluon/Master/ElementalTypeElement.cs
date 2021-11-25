using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ElementalTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Label;

		[SerializeField]
		private float _DamageRatioNoElementP2E;

		[SerializeField]
		private float _DamageRatioFireP2E;

		[SerializeField]
		private float _DamageRatioWaterP2E;

		[SerializeField]
		private float _DamageRatioWindP2E;

		[SerializeField]
		private float _DamageRatioLightP2E;

		[SerializeField]
		private float _DamageRatioDarkP2E;

		[SerializeField]
		private float _DamageRatioNoElementE2P;

		[SerializeField]
		private float _DamageRatioFireE2P;

		[SerializeField]
		private float _DamageRatioWaterE2P;

		[SerializeField]
		private float _DamageRatioWindE2P;

		[SerializeField]
		private float _DamageRatioLightE2P;

		[SerializeField]
		private float _DamageRatioDarkE2P;

		public int Id => default(int);

		public string Label => null;

		public float DamageRatioNoElementP2E => default(float);

		public float DamageRatioFireP2E => default(float);

		public float DamageRatioWaterP2E => default(float);

		public float DamageRatioWindP2E => default(float);

		public float DamageRatioLightP2E => default(float);

		public float DamageRatioDarkP2E => default(float);

		public float DamageRatioNoElementE2P => default(float);

		public float DamageRatioFireE2P => default(float);

		public float DamageRatioWaterE2P => default(float);

		public float DamageRatioWindE2P => default(float);

		public float DamageRatioLightE2P => default(float);

		public float DamageRatioDarkE2P => default(float);
	}
}
