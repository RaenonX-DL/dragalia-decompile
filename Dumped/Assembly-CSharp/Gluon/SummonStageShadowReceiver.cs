/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageShadowReceiver : MonoBehaviour
	{
		// Fields
		private readonly Vector3 amuletShadowShot2Offset;
		public ShadowSetting shadowSetting;
		private Vector3 beginPosition;
		private SummonStageShadowEmitter _emitter;
	
		// Properties
		public SummonStageShadowEmitter emitter { get; set; }
	
		// Nested types
		public class ShadowSetting
		{
			// Fields
			public float farDistance;
			public bool followXZPosition;
			public float scaleMaxVal;
			public float offsetY;
			public float offsetX;
			public bool applyAmuletShot2Offset;
	
			// Constructors
			public ShadowSetting();
		}
	
		// Constructors
		public SummonStageShadowReceiver();
	
		// Methods
		public void Awake();
		public void Update();
	}
}
