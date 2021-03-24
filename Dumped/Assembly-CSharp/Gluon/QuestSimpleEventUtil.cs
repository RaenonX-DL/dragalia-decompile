/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSimpleEventUtil : MonoBehaviour
	{
		// Fields
		private static bool _isShowEventInfo;
	
		// Properties
		public static bool IsShowEventInfo { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public int eventId;
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _RequestSimpleEventEntry_b__0(SimpleEventEntryResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _RequestSimpleEventData_b__0(SimpleEventGetEventDataResponse response);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public int EventId;
			public UnityAction completeCallback;
			public Action gotEventDataCallback;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _CheckForBeforeTransition_b__0();
			internal void _CheckForBeforeTransition_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public DownloadOperation downloadOperation;
			public __c__DisplayClass24_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass24_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_2
		{
			// Fields
			public SelectableDownloadPopup popup;
			public __c__DisplayClass24_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass24_2();
	
			// Methods
			internal void _CheckForBeforeTransition_b__2();
			internal void _CheckForBeforeTransition_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public Action successCallback;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _RequestEventData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public int eventId;
			public Action continueChangingToEventScene;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _SimpleEventLoginCheck_b__0();
		}
	
		// Constructors
		public QuestSimpleEventUtil();
		static QuestSimpleEventUtil();
	
		// Methods
		public static bool IsPrologue(EventDataElement data);
		public static bool IsHowToButton(EventDataElement data);
		public static EventDataElement IsEventItemTopView(int eventId);
		public static List<SimpleEventItemElement> IsGetSimpleEventItemList(int eventId);
		public static bool IsEventExchange(int eventId);
		public static bool IsEpilogue(EventDataElement data);
		public static bool ShouldGotoPrologue(QuestEventGroupElement groupElement);
		public static bool ShouldGotoPrologue(int eventId);
		public static bool IsPrologueCleared(int eventId);
		public static bool IsEpilogueCleared(int eventId);
		public static bool IsGotoPrologue(int eventId);
		public static bool IsEntryRequestNeeded();
		public static void RequestSimpleEventEntry(int eventId, Action continueChangingToEventScene);
		public static void RequestSimpleEventData(int eventId, Action continueChangingToEventScene, Action<ErrorType, int> onError = null);
		public static void GoToEventQuestSceneErrorHandler(ErrorType errorType, int errorCode);
		public static bool GotoPrologue(int eventid, string backScene = "NormalEventSelect");
		public static void RemoveTouchGuardHandler();
		public static bool IsGotoEpilogue(int eventId);
		public static bool GoToEpilogue(int eventId, string backScene);
		public static bool EnteredEvent(EventKindType eventType, int eventId);
		public static void CheckForBeforeTransition(int EventId, UnityAction completeCallback);
		public static void RequestEventData(int eventId, Action successCallback, Action<ErrorType, int> onError, bool forceRequest = true);
		public static void SimpleEventLoginCheck(int eventId, Action continueChangingToEventScene);
	}
}
