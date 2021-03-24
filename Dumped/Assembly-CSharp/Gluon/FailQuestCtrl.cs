/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FailQuestCtrl
	{
		// Fields
		private bool needsFailResult;
		private bool needsRetry;
	
		// Constructors
		public FailQuestCtrl();
	
		// Methods
		public void Timeup();
		public void AllDead();
		public void ContinueImpossible();
		public void ObjectiveFailed();
		public void Retry(int questId);
		public void Update();
		public bool NeedsRetry();
		public bool NeedsFailResult();
		private bool IsPlayingWithOtherPlayer();
		private void CheckNeedsFailResult();
		private void CheckNeedsRetry(int questId);
		private void CheckRebattleTimeout();
		private void SendFail();
	}
}
