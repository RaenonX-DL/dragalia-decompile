using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FormationBulletData : BulletData
	{
		[Serializable]
		public class ChildParameter
		{
			public bool isFoldout;

			public Vector3 offsetPos;

			public BulletData bulletData;
		}

		[Flags]
		public enum FireTrigger
		{
			None = 0x0,
			Generate = 0x1,
			CharacterMove = 0x2,
			FixedTime = 0x4,
			Tap = 0x8
		}

		[Serializable]
		public class SoundEffect
		{
			public string name;

			public string controllerKey;

			public float fadeoutTime;
		}

		public static readonly int childNumMax;

		[SerializeField]
		[HideInInspector]
		private int _childNum;

		[SerializeField]
		[HideInInspector]
		private ChildParameter[] _child;

		[SerializeField]
		[HideInInspector]
		private Vector3 _rotationSpeed;

		[SerializeField]
		[HideInInspector]
		private FireTrigger _fireTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _noCheckCollision;

		[SerializeField]
		[HideInInspector]
		private bool _destroyAlone;

		[SerializeField]
		[HideInInspector]
		private bool _overrideExistingFormationBullet;

		[SerializeField]
		[HideInInspector]
		private SoundEffect _se;

		public int childNum => default(int);

		public ChildParameter[] child => null;

		public Vector3 rotationSpeed => default(Vector3);

		public FireTrigger fireTrigger => default(FireTrigger);

		public bool noCheckCollision => default(bool);

		public bool destroyAlone => default(bool);

		public bool overrideExistingFormationBullet => default(bool);

		public SoundEffect se => null;
	}
}
