using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventSubBanner : MonoBehaviour
	{
		public Image mainImage;

		private Material mainMaterial;

		public QuestEventBannerController Controller
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

		public bool IsLoadCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EventDataElement EventData
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

		public void Init(EventDataElement element)
		{
		}

		public static bool IsValid(EventDataElement element)
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		private static bool IsValidEventQuest(EventDataElement element)
		{
			return default(bool);
		}

		private static bool IsValidEventNotice(EventDataElement element)
		{
			return default(bool);
		}

		private void InitEventNotice(EventDataElement element)
		{
		}

		private void InitEventQuest(EventDataElement element)
		{
		}

		public void OnPressed()
		{
		}

		public string GetTitle()
		{
			return null;
		}

		public void SetEnabled(bool enabled)
		{
		}

		public void SetOn(bool isOn)
		{
		}

		public static bool IsBetweenStartAndEndDate(string startDate, string endDate)
		{
			return default(bool);
		}

		private void ApplyLoadedTexture(Material bannerAsset, Material maskAsset)
		{
		}
	}
}
