/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class DropBulletData : BulletWithMarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _fixedAim;
		[HideInInspector]
		[SerializeField]
		private Vector3 _aimPosition;
		[HideInInspector]
		[SerializeField]
		private bool _useLegacyClearMarker;
	
		// Properties
		public bool fixedAim { get; }
		public Vector3 aimPosition { get; }
		public bool useLegacyClearMarker { get; }
	
		// Constructors
		public DropBulletData();
	}
}
