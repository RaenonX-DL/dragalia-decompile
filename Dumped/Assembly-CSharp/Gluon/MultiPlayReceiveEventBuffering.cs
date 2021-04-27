/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Common;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayReceiveEventBuffering
	{
		// Fields
		private List<RecvEventData> _buffer;
		private Dictionary<EventCode, Func<object, bool>> _handlerDic;
	
		// Nested types
		private struct RecvEventData
		{
			// Fields
			public EventCode code;
			public CharacterState state;
			public Dead dead;
			public CharacterSpecialState specialState;
			public object data;
		}
	
		// Constructors
		public MultiPlayReceiveEventBuffering();
	
		// Methods
		public void Clear();
		public void RegisterHandler(EventCode code, Func<object, bool> handler);
		public void CheckBufferredEvent();
		public void Add(CharacterState recvEvent);
		public void Add(Dead recvEvent);
		public void Add(CharacterSpecialState recvEvent);
		public void Add(EventCode code, object recvEvent);
	}
}
