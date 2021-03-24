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
	public class EnergyPointMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private EnergyPoint _tempSendEvent;
	
		// Constructors
		public EnergyPointMultiPlayService();
		static EnergyPointMultiPlayService();
	
		// Methods
		public void SetDirty();
		public void UpdateSendEvent(CharacterBase owner);
		public void OnRecieveCurrentEp(CharacterBase owner, EnergyPoint recvEvent);
		private void SendCurrentEp(CharacterBase owner);
	}
}
