using System.Collections.Generic;

namespace Gluon
{
	public static class MultipleCharaData
	{
		private static Dictionary<int, List<MultipleCharaDataElement>> multipleCharaDataTable;

		private static Dictionary<int, int> multipleCharaCurrentIndexTable;

		public static void UpdateMultipleCharaCurrentIndexTableByRandom()
		{
		}

		public static MultipleCharaDataElement ExtractDefaultCharaData(int charaId)
		{
			return null;
		}

		public static MultipleCharaDataElement ExtractCurrentMultipleCharaData(int charaId)
		{
			return null;
		}

		public static int ExtractCurrentMultipleCharacterIndex(int charaId)
		{
			return default(int);
		}

		public static bool IsMultipleCharacter(int charaId)
		{
			return default(bool);
		}

		public static int ExtractRandomCharaDataIndex(int charaId)
		{
			return default(int);
		}

		public static List<MultipleCharaDataElement> CreateSameGroupCharaDataList(int charaId)
		{
			return null;
		}

		public static int CalcMultipleCharaDataCount(int charaId)
		{
			return default(int);
		}
	}
}
