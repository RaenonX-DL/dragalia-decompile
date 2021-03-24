/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Common;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonSequenceCheck
	{
		// Fields
		private Dictionary<int, ushort> _sequenceIdDic;
		private ushort _nextSequenceId;
		private bool _isCheckEnabled;
	
		// Constructors
		public PhotonSequenceCheck();
	
		// Methods
		public void BeginCheck();
		public void Clear();
		public bool OnReceive(EventCode code, int actorId, ushort sequenceId);
		public ushort TakeNextSequenceId(EventCode code);
		private static bool IsPhotonServerSendEventCode(EventCode code);
		private static bool IsPhotonServerReceiveEventCode(EventCode code);
		private bool IsNextSequenceId(ushort currentId, ushort newId);
	}
}
