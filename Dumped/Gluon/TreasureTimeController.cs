using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TreasureTimeController : MonoBehaviour
	{
		[SerializeField]
		private Text treasureTimeRemainText;

		[SerializeField]
		private Image[] treasureImages;

		protected float timeElapsed;

		private EventQuestModel.TreasureTimeType _treasureType;

		private float remain;

		private bool isStarted;

		public EventQuestModel.TreasureTimeType treasureType
		{
			get
			{
				return default(EventQuestModel.TreasureTimeType);
			}
			set
			{
			}
		}

		public Action startedCallback
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

		public Action endedCallback
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

		public void SetContent(int eventId)
		{
		}

		protected void Update()
		{
		}

		private void UpdateSecond()
		{
		}
	}
}
