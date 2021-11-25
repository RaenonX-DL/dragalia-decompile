using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventBanner : MonoBehaviour
	{
		public enum TargetEventType
		{
			ForQuestSelectScene,
			ForFortScene
		}

		public enum TargetEventPeriod
		{
			All,
			EnableToPlay
		}

		[SerializeField]
		private Image bannerImage;

		[SerializeField]
		private GameObject bannerRoot;

		[SerializeField]
		private bool _isInitializeOnStart;

		private TargetEventType _targetEventType;

		private TargetEventPeriod _targetEventPeriod;

		private PointerEventHandler pointerEventHandler;

		private List<EventDataElement> bannerData;

		private EventDataElement nowMainEventData;

		[SerializeField]
		private Text durationText;

		public bool isInitializeOnStart
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public TargetEventType targetEventType
		{
			get
			{
				return default(TargetEventType);
			}
			set
			{
			}
		}

		public TargetEventPeriod targetEventPeriod
		{
			get
			{
				return default(TargetEventPeriod);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void SetDisp(bool value)
		{
		}

		public void SetCallback(UnityAction call)
		{
		}

		public void Initialize()
		{
		}

		public static bool IsTargetEventType(QuestEventGroupElement groupElement, TargetEventType targetEventType)
		{
			return default(bool);
		}

		public static bool IsTargetEventPeriod(EventDataElement eventDataElement, TargetEventPeriod targetEventPeriod)
		{
			return default(bool);
		}

		public void OnClickBannerIcon()
		{
		}

		private IEnumerator EventQuestTransition()
		{
			return null;
		}
	}
}
