using System;
using System.Collections.Generic;
using Gluon.Common;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayReceiveEventBuffering
	{
		private struct RecvEventData
		{
			public EventCode code;

			public CharacterState state;

			public Dead dead;

			public CharacterSpecialState specialState;

			public object data;
		}

		private List<RecvEventData> _buffer;

		private Dictionary<EventCode, Func<object, bool>> _handlerDic;

		public void Clear()
		{
		}

		public void RegisterHandler(EventCode code, Func<object, bool> handler)
		{
		}

		public void CheckBufferredEvent()
		{
		}

		public void Add(CharacterState recvEvent)
		{
		}

		public void Add(Dead recvEvent)
		{
		}

		public void Add(CharacterSpecialState recvEvent)
		{
		}

		public void Add(EventCode code, object recvEvent)
		{
		}
	}
}
