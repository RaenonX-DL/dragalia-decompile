namespace Gluon
{
	public class SerializeManager
	{
		private const string JSON_DIR_NAME = "/Gluon/";

		private FacilitySaveData unPackedSaveData;

		private bool isSaveDataUnpacked;

		public static void SaveJsonFile(string fileName, string jsonStr)
		{
		}

		public static string LoadJsonFile(string fileName)
		{
			return null;
		}

		public static string[] GetJsonFileNameList()
		{
			return null;
		}

		public static void SaveMsgpackFile(string fileName, byte[] data)
		{
		}

		public static byte[] LoadMsgpackFile(string fileName)
		{
			return null;
		}

		public void SerializeFacilities(string fileName)
		{
		}

		private byte[] SaveFacilityToMsgpack()
		{
			return null;
		}

		public void LoadSerializedFacilities(string fileName)
		{
		}

		private void LoadFacilityFromMsgpack(byte[] data)
		{
		}

		public void RegisterPreLoadingFacilitiesFromSaveData(string fileName, bool async)
		{
		}

		public void RegisterLoadingFacilitiesFromSaveData(string fileName, bool async)
		{
		}

		private void RegisterLoadingFacilityFromMsgpack(byte[] data, bool async)
		{
		}
	}
}
