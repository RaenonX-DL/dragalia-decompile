/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayBRCtrl
	{
		// Fields
		private MultiPlayReceiveEventBuffering _recvEventBuffering;
		private BRPulse _brPulse;
		[CompilerGenerated]
		private bool _IsBRTutorial_k__BackingField;
		private bool _isInitWorldRequested;
		private static readonly float _extraParamSendIntervalTime;
		private float _extraParamSendDelayTimer;
	
		// Properties
		public bool IsBRTutorial { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public MultiPlayBRCtrl();
		static MultiPlayBRCtrl();
	
		// Methods
		public void Update();
		public void OnReceiveBREvent(BRCreateItemEvent recvEvent);
		private bool TryReceiveBREvent(BRGetItemEvent recvEvent);
		public void OnReceiveBREvent(BRGetItemEvent recvEvent);
		public void OnReceiveBREvent(BRInitWorld recvEvent);
		public void OnReceiveGameStep(GameStepEvent.StepTypes step);
		public void SetBRPulse(BRPulse pulse);
		public void OnReceiveBREvent(BRNotifyEvent recvEvent);
		private void CheckInitWorld();
		private void SendExtraParam();
		[CompilerGenerated]
		private bool _.ctor_b__9_0(object recvEvent);
	}
}
