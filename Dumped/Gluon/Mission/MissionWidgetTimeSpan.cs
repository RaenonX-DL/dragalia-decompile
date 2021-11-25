using System;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetTimeSpan : MonoBehaviour
	{
		public enum Type
		{
			Period,
			ReceivingTime
		}

		[SerializeField]
		[Header("é\u0096\u008bå\u0082¬æ\u009c\u009fé\u0096\u0093")]
		public Text text;

		[SerializeField]
		[Header("ã\u0082¿ã\u0082¤ã\u0083\u00a0ã\u0083ªã\u0083\u009fã\u0083\u0083ã\u0083\u0088ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		public Image iconLimit;

		public void Set(Type type, DateTime start, DateTime end)
		{
		}

		public void Initialize(MissionTableViewData data)
		{
		}
	}
}
