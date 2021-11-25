using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class GrowthBaseDataList
	{
		public List<GrowthBaseCommonData> baseDataList;

		public GrowthBaseDataList(DataManager.GameData<CharaList> list)
		{
		}

		public GrowthBaseDataList(DataManager.GameData<WeaponList> list)
		{
		}

		public GrowthBaseDataList(DataManager.GameData<DragonList> list)
		{
		}

		public GrowthBaseDataList(DataManager.GameData<AbilityCrestList> list)
		{
		}
	}
}
