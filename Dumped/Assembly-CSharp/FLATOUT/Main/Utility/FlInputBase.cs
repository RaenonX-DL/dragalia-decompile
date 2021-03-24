/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlInputBase
	{
		// Fields
		protected BaseStateTypes _currentState;
		protected FlUIManager _uiManager;
		protected bool _enable;
		protected bool _prevEnable;
		protected int _inputIndex;
		protected float _currentDownLoopTime;
		protected float _currentSelectTime;
		protected List<FlObjectBase> _hitObjectList;
		protected List<FlUIBase> _hitInputUIList;
	
		// Properties
		public bool Enable { get; }
		public int InputIndex { get; }
	
		// Nested types
		public enum BaseStateTypes
		{
			Wait_Init = 0,
			Wait_Loop = 1,
			Down_Init = 2,
			Down_Loop = 3,
			Select_Init = 4,
			Select_Loop = 5
		}
	
		// Constructors
		public FlInputBase(FlUIManager uiManager, int inputIndex);
	
		// Methods
		public virtual void _Reset();
		public virtual void _Update();
		protected virtual void _Update_Common_Start();
		protected virtual void _Update_Common_End();
		protected virtual void _Update_Wait_Init();
		protected virtual void _Update_Wait_Loop();
		protected virtual void _Update_Down_Init();
		protected virtual void _Update_Down_Loop();
		protected virtual void _Update_Select_Init();
		protected virtual void _Update_Select_Loop();
		public virtual void _SetEnable(bool enable);
		public virtual FlInputDownTypes _GetDown(FlUIBase inputUI);
		public virtual FlInputDownLoopTypes _GetDownLoop(FlUIBase inputUI);
		public virtual FlInputUpTypes _GetUp(FlUIBase inputUI);
	}
}
