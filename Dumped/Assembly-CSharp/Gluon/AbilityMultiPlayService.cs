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
	public class AbilityMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private CharacterBase _owner;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private ChangeAbility _tempSendEvent;
	
		// Properties
		private Ability OwnerAblity { get; }
	
		// Constructors
		public AbilityMultiPlayService(CharacterBase owner);
		static AbilityMultiPlayService();
	
		// Methods
		public void SetDirty();
		public void UpdateSendEvent();
		public void OnRecieveCurrentAbility(ChangeAbility recvEvent);
		public void SendImmediately();
		private void SendCurrentAbility();
		private bool CanSendAbility();
	}
}
