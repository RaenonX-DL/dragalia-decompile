using System.Collections.Generic;

namespace Gluon
{
	public class CharacterBuffRestoreCtrl
	{
		private struct RestoreTrait
		{
			public bool durationNum;

			public bool IsRestoreAny()
			{
				return default(bool);
			}
		}

		private struct RestoreData
		{
			public RestoreTrait trait;

			public int actionConditionId;

			public int abilityId;

			public CharacterBuffType type;

			public int durationNum;
		}

		private List<RestoreData> _restoreDataList;

		public bool NeedRestore(int actionConditionId, int abilityId)
		{
			return default(bool);
		}

		public void SaveRestoreData(ref CharacterBuff.BuffUnion buff)
		{
		}

		public bool HasRestoreData(int actionConditionId, int abilityId, CharacterBuffType type = CharacterBuffType.None)
		{
			return default(bool);
		}

		public void Restore(int actionConditionId, int abilityId, ref int durationNum, CharacterBuffType type = CharacterBuffType.None)
		{
		}

		public void ClearAll()
		{
		}

		private RestoreTrait GetRestoreTrait(int actionConditionId)
		{
			return default(RestoreTrait);
		}

		private int FindRestoreDataIndex(int actionConditionId, int abilityId, CharacterBuffType type)
		{
			return default(int);
		}
	}
}
