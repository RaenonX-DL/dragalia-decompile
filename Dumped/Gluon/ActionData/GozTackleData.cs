using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class GozTackleData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _tackleDistance;

		[SerializeField]
		[HideInInspector]
		private float _tackleSpeed;

		[SerializeField]
		[HideInInspector]
		private float _tackleInterval;

		[SerializeField]
		[HideInInspector]
		private float _returnInterval;

		[SerializeField]
		[HideInInspector]
		private string _tackleMotion;

		[SerializeField]
		[HideInInspector]
		private string _returnMotion;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private string _hitDifficultyLabel;

		[SerializeField]
		[HideInInspector]
		private float _collisionRadius;

		public const float DEFAULT_HIT_INTERVAL = 0.5f;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private int _crashActionId;

		[SerializeField]
		[HideInInspector]
		private string _auraEffKey;

		[SerializeField]
		[HideInInspector]
		private string _returnEffect;

		[SerializeField]
		[HideInInspector]
		private string _seCharge;

		[SerializeField]
		[HideInInspector]
		private string _seTackle;

		[SerializeField]
		[HideInInspector]
		private string _seReturn;

		public float tackleDistance => default(float);

		public float tackleSpeed => default(float);

		public float tackleInterval => default(float);

		public float returnInterval => default(float);

		public string tackleMotion => null;

		public string returnMotion => null;

		public MarkerData marker => null;

		public string hitDifficultyLabel => null;

		public float collisionRadius => default(float);

		public float collisionHitInterval => default(float);

		public int crashActionId => default(int);

		public string auraEffKey => null;

		public string returnEffect => null;

		public string seCharge => null;

		public string seTackle => null;

		public string seReturn => null;
	}
}
