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
	public class TanatosHourGlassMultiPlayService
	{
		// Fields
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private CharacterSpecialState _tempSendEvent;
		private Dictionary<int, int> _multiPartyDeathCountDic;
		private int _lastMyHourGlass;
	
		// Constructors
		public TanatosHourGlassMultiPlayService(Dictionary<int, int> multiPartyDeathCountDic);
		static TanatosHourGlassMultiPlayService();
	
		// Methods
		public void UpdateSendEvent(EnemyCharacter owner);
		private void SendHourGlass(CharacterBase owner, int hourGlass);
		public void OnRecieveHourGlass(CharacterSpecialState recvEvent);
	}
}
