/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayQuestStartProcTimerCtrl
	{
		// Fields
		private const float stateTotalTimeThreshold = 10f;
		private float stateTotalTime;
		private long procTotalTime;
		private List<string> recordNames;
		private List<long> recordTimes;
		private Stopwatch sw;
		private bool isStarted;
		private bool isSended;
	
		// Constructors
		public PlayQuestStartProcTimerCtrl();
	
		// Methods
		private void Start();
		public void Record(string procName);
		public void Send();
		public void Update();
	}
}
