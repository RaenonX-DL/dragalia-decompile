/*
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
	public class MultiPlayAuraCtrl
	{
		// Fields
		public static readonly int DefaultKey;
		private AuraEvent _tempSendAuraEvent;
		private Queue<AuraEventCommandData> _auraEventCommandDataQueue;
		private int _nextMultiPlayKey;
		private int _stackLevel;
	
		// Constructors
		public MultiPlayAuraCtrl();
		static MultiPlayAuraCtrl();
	
		// Methods
		public void Initialize();
		public void CommandClear();
		public int CreateMultiPlayKey();
		private AuraEventCommandData CreateCommandData(CharacterBase target, AuraEventCommandType commandType, int multiPlayKey);
		private AuraEventCommandData CreateCommandData(CharacterBase target, AuraEventCommandType commandType, CharacterAuraCtrl.Parameter parameter, RemoveBuffReason reason = RemoveBuffReason.Other);
		public void NotifyAdd(CharacterBase owner, CharacterAuraCtrl.Parameter parameter);
		public void NotifyUpdate(CharacterBase owner, CharacterAuraCtrl.Parameter parameter, bool durationUpdate);
		public void NotifyRemove(CharacterBase owner, int multiPlayKey, RemoveBuffReason reason);
		public void NotifyPublished(CharacterBase owner, int multiPlayKey, CharacterAuraCtrl.PublishParam publishParam, int maxLimitLevel);
		public void OnRecieveAuraEvent(AuraEvent recvEvent);
		public void BeginStack();
		public void EndStack();
		private void SendAuraEvent();
	}
}
