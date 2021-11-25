using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidEventsClient : IEventsClient
	{
		private AndroidJavaObject mEventsClient;

		public AndroidEventsClient(AndroidJavaObject account)
		{
		}

		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback)
		{
		}

		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback)
		{
		}

		public void IncrementEvent(string eventId, uint stepsToIncrement)
		{
		}

		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert)
		{
			return null;
		}

		private static Event CreateEvent(AndroidJavaObject eventJava)
		{
			return null;
		}
	}
}
