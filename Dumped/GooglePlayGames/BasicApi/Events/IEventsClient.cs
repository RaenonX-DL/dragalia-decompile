using System;
using System.Collections.Generic;

namespace GooglePlayGames.BasicApi.Events
{
	public interface IEventsClient
	{
		void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);

		void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);

		void IncrementEvent(string eventId, uint stepsToIncrement);
	}
}
