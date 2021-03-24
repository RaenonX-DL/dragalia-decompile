﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbnormalStatusMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private CharacterBase _owner;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private ChangeAbnormalStatus _tempSendChangeEvent;
		private short[] _tempSendChangeResists;
		private SlipDamage _tempSendSlipDamageEvent;
	
		// Constructors
		public AbnormalStatusMultiPlayService(CharacterBase owner);
		static AbnormalStatusMultiPlayService();
	
		// Methods
		public void SetDirty();
		public void UpdateSendEvent();
		private void SendCurrentAbnormalStatus();
		public void OnReceiveCurrentAbnormalStatus(ChangeAbnormalStatus recvEvent);
		public void NotifySlipDamage(CharacterBase owner, int slipDamage, AbnormalStatusType type, CharacterBase attacker, bool isFollower, Dictionary<CharacterBase, int> slipDamageOwnerDict);
		public void OnReceiveSlipDamage(CharacterBase owner, CharacterBase attacker, SlipDamage slipDamage);
	}
}
