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
	public class OdCounteredHitData : HitData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _hitDuration;
		[HideInInspector]
		[SerializeField]
		private MarkerData _markerData;
		[HideInInspector]
		[SerializeField]
		private ActionPartsOdCounteredHit.IconBasePosition _iconBase;
		[HideInInspector]
		[SerializeField]
		private Vector3 _iconOffset;
	
		// Properties
		public float hitDuration { get; }
		public MarkerData markerData { get; }
		public ActionPartsOdCounteredHit.IconBasePosition iconBase { get; }
		public Vector3 iconOffset { get; }
	
		// Constructors
		public OdCounteredHitData();
	}
}
