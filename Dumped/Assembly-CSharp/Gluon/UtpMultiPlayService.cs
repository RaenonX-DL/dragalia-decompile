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
	public class UtpMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private CharacterSpecialState _tempSendEvent;
	
		// Constructors
		public UtpMultiPlayService();
		static UtpMultiPlayService();
	
		// Methods
		public void SetDirty();
		public void UpdateSendEvent(CharacterBase owner);
		private void SendCurrentPoint(CharacterBase owner);
	}
}
