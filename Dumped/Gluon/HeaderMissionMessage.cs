using Gluon.Http;
using UnityEngine.UI;

namespace Gluon
{
	public class HeaderMissionMessage : HeaderMessageBase<MissionNoticeData>
	{
		public Image ribbonLeft;

		public Image ribbonRight;

		public Image missionStamp;

		public Image drillMissionStamp;

		public static void UpdateData()
		{
		}

		private static void AddMessage(MissionNotice mission_notice)
		{
		}

		protected override bool isShowOtherNotice()
		{
			return default(bool);
		}

		protected override void UpdateMessageUI(MissionNoticeData messageData)
		{
		}
	}
}
