/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class ToggleDoor : DoorBase
	{
		// Fields
		public ToggleSwitchColor color;
		protected int open;
	
		// Nested types
		private enum ToggleDoorStatus
		{
			NONE = 0,
			OPEN = 1,
			CLOSE = 2
		}
	
		// Constructors
		public ToggleDoor();
	
		// Methods
		protected override void Start();
		public void Toggle();
	}
}
