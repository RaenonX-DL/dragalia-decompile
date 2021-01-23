/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public abstract class FlBlendBase
	{
		// Fields
		protected BlendTypes _blendType;
		protected float _currentBlendTime;
		protected float _blendTime;
		protected float _currentBlendValue;
		protected float _currentFixBlendValue;
		protected bool _pause;
	
		// Properties
		public BlendTypes BlendType { get; }
		public float CurrentBlendTime { get; }
		public float BlendTime { get; }
		public float CurrentBlendValue { get; }
		public float CurrentFixBlendValue { get; }
		public bool Pause { get; }
	
		// Nested types
		public enum BlendTypes
		{
			Linear = 0,
			Up = 1,
			Down = 2,
			UpDown = 3,
			Up2 = 4,
			Down2 = 5,
			UpDown2 = 6
		}
	
		// Constructors
		protected FlBlendBase();
	
		// Methods
		public virtual void Reset();
		public virtual void Update(float deltaTime);
		public virtual void SetBlendType(BlendTypes blendType);
		public virtual void SetBlendTime(float blendTime);
		public virtual void SetCurrentBlendTime(float currentBlendTime);
		public virtual void SetPause(bool pause);
	}
}
