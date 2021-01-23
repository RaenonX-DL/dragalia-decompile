/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlBlendVector : FlBlendBase
	{
		// Fields
		private Vector3 _startValue;
		private Vector3 _endValue;
		private Vector3 _currentValue;
	
		// Properties
		public Vector3 StartValue { get; }
		public Vector3 EndValue { get; }
		public Vector3 CurrentValue { get; }
	
		// Constructors
		public FlBlendVector(Vector3 startValue, Vector3 endValue, float blendTime, BlendTypes blendModeType);
	
		// Methods
		public override void Reset();
		public override void Update(float deltaTime);
		private void UpdateCurrentValue();
		public virtual void SetStartValue(Vector3 startValue);
		public virtual void SetEndValue(Vector3 endValue);
	}
}
