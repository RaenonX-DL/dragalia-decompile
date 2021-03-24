/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlBlendValue : FlBlendBase
	{
		// Fields
		private float _startValue;
		private float _endValue;
		private float _currentValue;
	
		// Properties
		public float StartValue { get; }
		public float EndValue { get; }
		public float CurrentValue { get; }
	
		// Constructors
		public FlBlendValue(float startValue, float endValue, float blendTime, BlendTypes blendModeType);
	
		// Methods
		public override void Reset();
		public override void Update(float deltaTime);
		private void UpdateCurrentValue();
		public virtual void SetStartValue(float startValue);
		public virtual void SetEndValue(float endValue);
	}
}
