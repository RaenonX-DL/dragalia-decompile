using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HumanCannonData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private float _waitPick;

		[SerializeField]
		[HideInInspector]
		private float _reelTime;

		[SerializeField]
		[HideInInspector]
		private float _waitFire;

		[SerializeField]
		[HideInInspector]
		private float _velocity;

		[SerializeField]
		[HideInInspector]
		private Vector3 _fireOffset;

		[SerializeField]
		[HideInInspector]
		private string _crashHitDifficultyLabel;

		[SerializeField]
		[HideInInspector]
		private string _freedHitDifficultyLabel;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private float _attachTiming;

		[SerializeField]
		[HideInInspector]
		private string _lightballEffName;

		[SerializeField]
		[HideInInspector]
		private int _startTrigger;

		[SerializeField]
		[HideInInspector]
		private int _freedTrigger;

		[SerializeField]
		[HideInInspector]
		private string _startSeName;

		[SerializeField]
		[HideInInspector]
		private string _fireSeName;

		[SerializeField]
		[HideInInspector]
		private string _freedSeName;

		public float radius => default(float);

		public float waitPick => default(float);

		public float reelTime => default(float);

		public float waitFire => default(float);

		public float velocity => default(float);

		public Vector3 fireOffset => default(Vector3);

		public string crashHitDifficultyLabel => null;

		public string freedHitDifficultyLabel => null;

		public string attachNodeName => null;

		public float attachTiming => default(float);

		public string lightballEffName => null;

		public int startTrigger => default(int);

		public int freedTrigger => default(int);

		public string startSeName => null;

		public string fireSeName => null;

		public string freedSeName => null;
	}
}
