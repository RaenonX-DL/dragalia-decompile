﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlKeyInput : FlInputBase
	{
		// Fields
		private FlUIBase _currentInputUI;
		private Vector2 _currentSelectDirection;
		private FlUIInputDirectionTypes _currentInputDirectionType;
		private FlInputRepeater _repeater;
	
		// Properties
		public FlInputRepeater Repeater { get; }
	
		// Constructors
		public FlKeyInput(FlUIManager uiManager, int inputIndex);
	
		// Methods
		protected override void _Update_Common_Start();
		protected override void _Update_Wait_Init();
		protected override void _Update_Wait_Loop();
		protected override void _Update_Down_Init();
		protected override void _Update_Down_Loop();
		protected override void _Update_Select_Init();
		protected override void _Update_Select_Loop();
		private void _UpdateSelection();
		public override FlInputDownTypes _GetDown(FlUIBase inputUI);
		public override FlInputDownLoopTypes _GetDownLoop(FlUIBase inputUI);
		public override FlInputUpTypes _GetUp(FlUIBase inputUI);
	}
}
