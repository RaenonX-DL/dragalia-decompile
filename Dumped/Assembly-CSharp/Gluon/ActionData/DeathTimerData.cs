/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class DeathTimerData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsDeathTimer.ProcType _procType;
		[HideInInspector]
		[SerializeField]
		private int _countMax;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string _burstEffName;
		public const int TIME_MARKER_MAX = 16;
		[HideInInspector]
		[SerializeField]
		private int _markerNum;
		[HideInInspector]
		[SerializeField]
		private DeathTimerUniqueCtrl.TimeMarker.Type[] _markerType;
		[HideInInspector]
		[SerializeField]
		private Vector3[] _markerPosition;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private float _chargeTime;
		[HideInInspector]
		[SerializeField]
		private string _timeMarkerEffName;
		[HideInInspector]
		[SerializeField]
		private string _fullChargeEffName;
		[HideInInspector]
		[SerializeField]
		private string _timeMarkerStartSeName;
		[HideInInspector]
		[SerializeField]
		private string _timeMarkerFullChargeSeName;
	
		// Properties
		public ActionPartsDeathTimer.ProcType procType { get; }
		public int countMax { get; }
		public string hitAttrLabel { get; }
		public string burstEffName { get; }
		public int markerNum { get; }
		public DeathTimerUniqueCtrl.TimeMarker.Type[] markerType { get; }
		public Vector3[] markerPosition { get; }
		public float radius { get; }
		public float chargeTime { get; }
		public string timeMarkerEffName { get; }
		public string fullChargeEffName { get; }
		public string timeMarkerStartSeName { get; }
		public string timeMarkerFullChargeSeName { get; }
	
		// Constructors
		public DeathTimerData();
	}
}
