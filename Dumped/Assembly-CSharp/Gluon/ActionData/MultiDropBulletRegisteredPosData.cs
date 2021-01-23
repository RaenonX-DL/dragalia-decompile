/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiDropBulletRegisteredPosData : DropBulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _generateInterval;
		[HideInInspector]
		[SerializeField]
		private float[] _markerDelay;
		public static int MARKER_DELAY_MAX;
	
		// Properties
		public float generateInterval { get; }
		public float[] markerDelay { get; }
	
		// Constructors
		public MultiDropBulletRegisteredPosData();
		static MultiDropBulletRegisteredPosData();
	}
}
