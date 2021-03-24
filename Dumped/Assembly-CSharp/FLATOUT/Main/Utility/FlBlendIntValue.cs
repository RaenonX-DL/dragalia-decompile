/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlBlendIntValue : FlBlendBase
	{
		// Fields
		private int _startValue;
		private int _endValue;
		private int _currentValue;
	
		// Properties
		public int StartValue { get; }
		public int EndValue { get; }
		public int CurrentValue { get; }
	
		// Constructors
		public FlBlendIntValue(int startValue, int endValue, float blendTime, BlendTypes blendModeType);
	
		// Methods
		public override void Reset();
		public override void Update(float deltaTime);
		private void UpdateCurrentValue();
		public virtual void SetStartValue(int startValue);
		public virtual void SetEndValue(int endValue);
	}
}
