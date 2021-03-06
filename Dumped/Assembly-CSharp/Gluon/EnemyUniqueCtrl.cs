﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyUniqueCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		protected EnemyCharacter _character;
	
		// Properties
		public EnemyCharacter character { get; }
	
		// Constructors
		public EnemyUniqueCtrl();
	
		// Methods
		public virtual void Initialize();
		public virtual float GetAtkValue();
		public virtual float GetDefValue();
		public virtual void OnChangeState(CharacterState state);
		public virtual void OnDisconnectUser(int disconnectActorId);
		public virtual void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent);
		public virtual void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent);
	}
}
