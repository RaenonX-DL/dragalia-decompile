using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class DeathTimerData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsDeathTimer.ProcType _procType;

		[SerializeField]
		[HideInInspector]
		private int _countMax;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private string _burstEffName;

		public const int TIME_MARKER_MAX = 16;

		[SerializeField]
		[HideInInspector]
		private int _markerNum;

		[SerializeField]
		[HideInInspector]
		private DeathTimerUniqueCtrl.TimeMarker.Type[] _markerType;

		[SerializeField]
		[HideInInspector]
		private Vector3[] _markerPosition;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private float _chargeTime;

		[SerializeField]
		[HideInInspector]
		private string _timeMarkerEffName;

		[SerializeField]
		[HideInInspector]
		private string _fullChargeEffName;

		[SerializeField]
		[HideInInspector]
		private string _timeMarkerStartSeName;

		[SerializeField]
		[HideInInspector]
		private string _timeMarkerFullChargeSeName;

		public Gluon.ActionPartsDeathTimer.ProcType procType => default(Gluon.ActionPartsDeathTimer.ProcType);

		public int countMax => default(int);

		public string hitAttrLabel => null;

		public string burstEffName => null;

		public int markerNum => default(int);

		public DeathTimerUniqueCtrl.TimeMarker.Type[] markerType => null;

		public Vector3[] markerPosition => null;

		public float radius => default(float);

		public float chargeTime => default(float);

		public string timeMarkerEffName => null;

		public string fullChargeEffName => null;

		public string timeMarkerStartSeName => null;

		public string timeMarkerFullChargeSeName => null;
	}
}
