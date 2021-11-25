using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetDetail : MonoBehaviour
	{
		private string missionName;

		private string spanDesc;

		[SerializeField]
		[Header("ã\u0083\u009fã\u0083\u0083ã\u0082·ã\u0083§ã\u0083³å\u0090\u008d")]
		public Text textMissionName;

		[SerializeField]
		[Header("é\u0096\u008bå\u0082¬æ\u009c\u009fé\u0096\u0093")]
		public bool useTimeSpan;

		public MissionWidgetTimeSpan timeSpan;

		[SerializeField]
		[Header("å\u00a0±é\u0085¬è©³ç\u00b4°")]
		public MissionWidgetDetailReward detailReward;

		public Text duplicateText;

		private void Start()
		{
		}

		public void SetTimeSpan(MissionWidgetTimeSpan.Type type, DateTime start, DateTime end)
		{
		}
	}
}
