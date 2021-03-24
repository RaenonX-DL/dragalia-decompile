/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonGaugeMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private float _nextSendEventTimer;
		private DragonGauge _tempSendEvent;
	
		// Properties
		private static float SendEventInterval { get; }
	
		// Constructors
		public DragonGaugeMultiPlayService();
	
		// Methods
		public void SetDirty(int currentDp);
		public void UpdateSendEvent(int currentDp);
		private void SendCurrentDragonGauge(int currentDp);
		public void OnReceiveEvent(DragonGauge recvEvent);
	}
}
