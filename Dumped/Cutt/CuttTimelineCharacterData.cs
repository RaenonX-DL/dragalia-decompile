using System;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineCharacterData : ICuttTimelineSetData
	{
		public enum KeyIndex
		{
			Transform,
			Motion,
			Eye,
			Mouth,
			Motion2,
			Motion3,
			Motion4,
			Motion5,
			GameObject,
			Rich
		}

		public CuttTimelineKeyCharacterTransformDataList transformKeys;

		public CuttTimelineKeyCharacterMotionDataList motionKeys;

		public CuttTimelineKeyCharacterEyeDataList eyeKeys;

		public CuttTimelineKeyCharacterMouthDataList mouthKeys;

		public CuttTimelineKeyCharacterMotionDataList motion2Keys;

		public CuttTimelineKeyCharacterMotionDataList motion3Keys;

		public CuttTimelineKeyCharacterMotionDataList motion4Keys;

		public CuttTimelineKeyCharacterMotionDataList motion5Keys;

		public CuttTimelineKeyCharacterGameObjectDataList gameObjectKeys;

		public CuttTimelineKeyCharacterRichDataList richKeys;

		private const int arraySize = 10;

		private ICuttTimelineKeyDataList[] keyDataListArray;

		private CuttTimelineKeyDataType[] keyDataType;

		private void BuildKeyDataListArray()
		{
		}

		public ICuttTimelineKeyDataList GetKeyList(int index)
		{
			return null;
		}

		public ICuttTimelineKeyDataList[] GetKeyListArray()
		{
			return null;
		}

		public CuttTimelineKeyDataType[] GetKeyTypeArray()
		{
			return null;
		}
	}
}
