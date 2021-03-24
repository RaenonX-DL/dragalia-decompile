/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SleepTimeoutCtrl
	{
		// Fields
		private bool _isInMatchingRoom;
		private bool _isInMultiPlay;
		private bool _isInQuest;
	
		// Constructors
		public SleepTimeoutCtrl();
	
		// Methods
		public void EnterMatchingRoom();
		public void LeaveMatchingRoom();
		public void EnterMultiPlay();
		public void LeaveMultiPlay();
		public void EnterQuest(bool isAutoPlayMode);
		public void LeaveQuest();
		public void SetAutoPlayMode(bool isAutoPlayMode);
		private void SetSleepPreventEnabled(bool enable);
	}
}
