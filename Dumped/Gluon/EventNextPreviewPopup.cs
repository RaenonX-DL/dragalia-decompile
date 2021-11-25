using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventNextPreviewPopup : PopupBase
	{
		public int imageCount;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private PageViewBase pageView;

		[SerializeField]
		private Text infoText;

		[SerializeField]
		private Text closeText;

		private AudioPlayback voice;

		private string voiceGroupName;

		private bool isSequelEventPreview;

		public static string popupPrefabPath;

		public static string pagePrefabPath;

		private static readonly string eventNoticeImageName;

		private static readonly string sequelEventNoticeImageName;

		public EventDataElement eventData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static EventNextPreviewPopup Create(EventDataElement eventData, bool isSequelEventPreview, [Optional] Transform parentTransform)
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private IEnumerator PlayVoiceCoroutine()
		{
			return null;
		}

		private void OnPageChanged(int pageIndex)
		{
		}
	}
}
