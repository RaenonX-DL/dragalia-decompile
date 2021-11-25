using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestSimpleEventUtil : MonoBehaviour
	{
		private static bool _isShowEventInfo;

		public static bool IsShowEventInfo
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static bool IsPrologue(EventDataElement data)
		{
			return default(bool);
		}

		public static bool IsHowToButton(EventDataElement data)
		{
			return default(bool);
		}

		public static EventDataElement IsEventItemTopView(int eventId)
		{
			return null;
		}

		public static List<SimpleEventItemElement> IsGetSimpleEventItemList(int eventId)
		{
			return null;
		}

		public static bool IsEventExchange(int eventId)
		{
			return default(bool);
		}

		public static bool IsEpilogue(EventDataElement data)
		{
			return default(bool);
		}

		public static bool ShouldGotoPrologue(QuestEventGroupElement groupElement)
		{
			return default(bool);
		}

		public static bool ShouldGotoPrologue(int eventId)
		{
			return default(bool);
		}

		public static bool IsPrologueCleared(int eventId)
		{
			return default(bool);
		}

		public static bool IsEpilogueCleared(int eventId)
		{
			return default(bool);
		}

		public static bool IsGotoPrologue(int eventId)
		{
			return default(bool);
		}

		public static bool IsEntryRequestNeeded()
		{
			return default(bool);
		}

		public static void RequestSimpleEventEntry(int eventId, Action continueChangingToEventScene)
		{
		}

		public static void RequestSimpleEventData(int eventId, Action continueChangingToEventScene, [Optional] Action<ErrorType, int> onError)
		{
		}

		public static void GoToEventQuestSceneErrorHandler(ErrorType errorType, int errorCode)
		{
		}

		public static bool GotoPrologue(int eventid, string backScene = "NormalEventSelect")
		{
			return default(bool);
		}

		public static void RemoveTouchGuardHandler()
		{
		}

		public static bool IsGotoEpilogue(int eventId)
		{
			return default(bool);
		}

		public static bool GoToEpilogue(int eventId, string backScene)
		{
			return default(bool);
		}

		public static bool EnteredEvent(EventKindType eventType, int eventId)
		{
			return default(bool);
		}

		public static void CheckForBeforeTransition(int EventId, UnityAction completeCallback)
		{
		}

		public static void RequestEventData(int eventId, Action successCallback, Action<ErrorType, int> onError, bool forceRequest = true)
		{
		}

		public static void SimpleEventLoginCheck(int eventId, Action continueChangingToEventScene)
		{
		}
	}
}
