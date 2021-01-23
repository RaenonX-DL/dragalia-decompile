/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonSuspendCheatChecker
	{
		// Fields
		private bool _isInBossBattle;
		private bool _isShortSuspendReceived;
		private bool _isSuspending;
		private long _lastSuspendTick;
		private static readonly int LongSuspendThreshold;
	
		// Nested types
		private enum SuspendSpans
		{
			ShortSuspend = 1,
			LongSuspend = 2
		}
	
		// Constructors
		public PhotonSuspendCheatChecker();
		static PhotonSuspendCheatChecker();
	
		// Methods
		public void Update();
		public void SetIsInBossBattle(bool isInBossBattle);
		public void OnApplicationPause(bool paused);
		private void OnApplicationResumed(SuspendSpans resumeEvent);
		private bool CheckDisconnectCondition(SuspendSpans resumeEvent);
		private long GetCurrentTick();
		private bool CheckIsLongSuspend(long currentTick, int threshold);
	}
}
