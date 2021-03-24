/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Events
{
	public interface IEventsClient
	{
		// Methods
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);
		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);
		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
