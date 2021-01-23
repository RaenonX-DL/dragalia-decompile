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
	public class SkillPointMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private SkillPoint _tempSendEvent;
	
		// Constructors
		public SkillPointMultiPlayService();
		static SkillPointMultiPlayService();
	
		// Methods
		public void SetDirty();
		public void UpdateSendEvent(CharacterBase owner);
		public void OnRecieveCurrentSp(CharacterBase owner, SkillPoint recvEvent);
		private void SendCurrentSp(CharacterBase owner);
	}
}
