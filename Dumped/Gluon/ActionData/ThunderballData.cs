using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ThunderballData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private float _lifetime;

		[SerializeField]
		[HideInInspector]
		private int _sparktimes;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private Vector3 _lineSize;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _seSpawn;

		[SerializeField]
		[HideInInspector]
		private string _seDischarge;

		public const float DEFAULT_HIT_INTERVAL = 0.5f;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public string hitAttrLabel => null;

		public float lifetime => default(float);

		public int sparktimes => default(int);

		public float radius => default(float);

		public Vector3 lineSize => default(Vector3);

		public string effectName => null;

		public string seSpawn => null;

		public string seDischarge => null;

		public float collisionHitInterval => default(float);
	}
}
