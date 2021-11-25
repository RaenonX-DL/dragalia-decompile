using System.Collections.Generic;

namespace Gluon
{
	public class BossStatusInfoUI : PlayerStatusInfoUI
	{
		private List<AbnormalStatusBase> _abnormalStatusList;

		protected override void CollectStatusInfo()
		{
		}

		private bool ApplyAbnormalStatusInfo(AbnormalStatusBase data, int startIndex, int endIndex, ref int index, ref int uiIndex)
		{
			return default(bool);
		}

		protected override CharaStatusInfoUI CreateStatusInfoUI()
		{
			return null;
		}
	}
}
