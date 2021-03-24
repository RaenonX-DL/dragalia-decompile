/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlInputRepeater
	{
		// Fields
		private RepeaterStateTypes _currentState;
		private float _currentRepeatTime;
		private bool _repeatStartFlag;
		private bool _repeatOn;
	
		// Nested types
		public enum RepeaterStateTypes
		{
			Wait_Init = 0,
			Wait_Loop = 1,
			First_Init = 2,
			First_Loop = 3,
			Second_Init = 4,
			Second_Loop = 5
		}
	
		// Constructors
		public FlInputRepeater();
	
		// Methods
		private void _Update_Common_Start();
		public void _Update();
		private void _Update_Common_End();
		private void _Update_Wait_Init();
		private void _Update_Wait_Loop();
		private void _Update_First_Init();
		private void _Update_First_Loop();
		private void _Update_Second_Init();
		private void _Update_Second_Loop();
		public bool GetRepeat();
		public void Start();
		public void End();
	}
}
