using System;
using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestMenuMemoryEventBanner : EventMenuCell
	{
		public enum Type
		{
			Active,
			NonActive
		}

		[SerializeField]
		private GameObject bottomObjectBuild;

		[SerializeField]
		private GameObject bottomObjectRaid;

		[SerializeField]
		private GameObject beforeJoinText;

		[SerializeField]
		private GameObject afterJoinText;

		[SerializeField]
		public Text plantLvText;

		public Text maxPlantLvText;

		public Text[] coloredTexts;

		public Text englishPlantLvText;

		public Text[] otherLanguageTexts;

		public GameObject normalNewGO;

		public Type type;

		private int eventId;

		private long updateToMarkingDate;

		private const string newPrefTemplate = "__MemoryEventCheckDate_{0}";

		public void SetContent(int eventId)
		{
		}

		private bool IsSameEventOpen(EventDataElement currentEventData)
		{
			return default(bool);
		}

		public static bool ShouldMemoryEventBannerMarkNew(EventDataElement eventData, ref long updateToMarkingDate)
		{
			return default(bool);
		}

		public override void OnCellTouched()
		{
		}

		private IEnumerator CheckAndDownload(Action onDone)
		{
			return null;
		}

		private static void GetAssetHashSet(int eventId, out HashSet<string> hashSet, out HashSet<string> withoutVoiceHashSet)
		{
		}

		private static void DeleteAllOtherMemoryEventAsset(int excludeEventId)
		{
		}
	}
}
