using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class UnisonData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsUnison.UnisonType _type;

		[SerializeField]
		[HideInInspector]
		private int _primaryActionId;

		[SerializeField]
		[HideInInspector]
		private int _secondryActionId;

		[SerializeField]
		[HideInInspector]
		private Vector3 _primaryOffsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _secondaryOffsetPos;

		[SerializeField]
		[HideInInspector]
		private float _primaryOffsetDir;

		[SerializeField]
		[HideInInspector]
		private float _secondaryOffsetDir;

		[SerializeField]
		[HideInInspector]
		private float _primaryDistace;

		[SerializeField]
		[HideInInspector]
		private float _secondaryDistace;

		[SerializeField]
		[HideInInspector]
		private bool _synchroTarget;

		[SerializeField]
		[HideInInspector]
		private bool _isTargetActionReset;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsUnison.UnisonType type => default(Gluon.ActionPartsUnison.UnisonType);

		public int primaryActionId => default(int);

		public int secondryActionId => default(int);

		public Vector3 primaryOffsetPos => default(Vector3);

		public Vector3 secondaryOffsetPos => default(Vector3);

		public float primaryOffsetDir => default(float);

		public float secondaryOffsetDir => default(float);

		public float primaryDistace => default(float);

		public float secondaryDistace => default(float);

		public bool synchroTarget => default(bool);

		public bool isTargetActionReset => default(bool);

		public bool guarantee => default(bool);
	}
}
