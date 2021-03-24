/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlMouseInput : FlInputBase
	{
		// Fields
		private Vector3 _currentScreenPosition;
		private Vector3 _prevScreenPosition;
	
		// Constructors
		public FlMouseInput(FlUIManager uiManager, int inputIndex);
	
		// Methods
		public override void _Update();
		protected override void _Update_Common_Start();
		protected override void _Update_Common_End();
	}
}
