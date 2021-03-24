/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayBuffFieldCtrl
	{
		// Fields
		private static long _nextBuffFieldId;
		private List<BuffFieldEvent> _requestEventQueue;
		private ActionStartParameter _tmpActionStartParam;
	
		// Constructors
		public MultiPlayBuffFieldCtrl();
	
		// Methods
		public void Update();
		public void RequestCreateBuffField(long buffFieldId, long actionPartsResourceId, string hitAttrLabel, Vector3 position, Quaternion rotation, CharacterBase owner, int actionId, int skillId, int actionProductId, ActionStartParameter actionStartParam, bool isHostRequest);
		public void OnReceiveBuffFieldEvent(BuffFieldEvent recvEvent);
		public void OnDisconnectUser(int disconnectActorId);
		private void CreateBuffField(BuffFieldEvent recvEvent, CharacterBase owner, BuffFieldCreateEventParam param);
		public static long CreateBuffFieldId();
		public static void ResetBuffFieldId();
	}
}
