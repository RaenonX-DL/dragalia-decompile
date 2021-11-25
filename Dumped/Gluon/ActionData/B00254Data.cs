using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class B00254Data : ActionParts.PartsData
	{
		public enum Behavior
		{
			attack,
			retreat
		}

		[SerializeField]
		[HideInInspector]
		private Behavior _behavior;

		[SerializeField]
		[HideInInspector]
		private int _generateNum;

		[SerializeField]
		[HideInInspector]
		private float _generateDelay;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMin;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMax;

		[SerializeField]
		[HideInInspector]
		private bool _isGenerateRangeRandom;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _effectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _effectUseElementalTrigger;

		public Behavior behavior => default(Behavior);

		public int generateNum => default(int);

		public float generateDelay => default(float);

		public float generateRangeMin => default(float);

		public float generateRangeMax => default(float);

		public bool isGenerateRangeRandom => default(bool);

		public MarkerData markerData => null;

		public string hitAttrLabel => null;

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;

		public string effectName => null;

		public string[] elementalEffectName => null;

		public int effectTriggerIdx => default(int);

		public bool effectInfluencedCharaterElement => default(bool);

		public bool effectUseElementalTrigger => default(bool);
	}
}
