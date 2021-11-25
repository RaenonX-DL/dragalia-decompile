using Gluon.Master;

namespace Gluon
{
	public class MissionNoticeData : MessageDataBase
	{
		public MissionNoticeType type;

		public int id;

		public int sortId;

		public MissionNoticeData(MissionDrillDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionBeginnerDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionPeriodDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionDailyDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionNormalDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionMainStoryDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionMemoryEventDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionAlbumDataElement element, int missionId)
		{
		}

		public MissionNoticeData(MissionSpecialDataElement element, int missionId)
		{
		}

		private void Init(MissionNoticeType type, int id, int sortId)
		{
		}

		public override void ReloadText()
		{
		}
	}
}
