/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidEventsClient : IEventsClient
	{
		// Fields
		private AndroidJavaObject mEventsClient;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Action<ResponseStatus, List<IEvent>> callback;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _FetchAllEvents_b__0(AndroidJavaObject annotatedData);
			internal void _FetchAllEvents_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public Action<ResponseStatus, IEvent> callback;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _FetchEvent_b__0(AndroidJavaObject annotatedData);
			internal void _FetchEvent_b__1(AndroidJavaObject exception);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0<T1, T2>
		{
			// Fields
			public Action<T1, T2> toConvert;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _ToOnGameThread_b__0(T1 val1, T2 val2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_1<T1, T2>
		{
			// Fields
			public T1 val1;
			public T2 val2;
			public __c__DisplayClass5_0<T1, T2> CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass5_1();
	
			// Methods
			internal void _ToOnGameThread_b__1();
		}
	
		// Constructors
		public AndroidEventsClient(AndroidJavaObject account);
	
		// Methods
		public void FetchAllEvents(DataSource source, Action<ResponseStatus, List<IEvent>> callback);
		public void FetchEvent(DataSource source, string eventId, Action<ResponseStatus, IEvent> callback);
		public void IncrementEvent(string eventId, uint stepsToIncrement);
		private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert);
		private static GooglePlayGames.BasicApi.Events.Event CreateEvent(AndroidJavaObject eventJava);
	}
}
