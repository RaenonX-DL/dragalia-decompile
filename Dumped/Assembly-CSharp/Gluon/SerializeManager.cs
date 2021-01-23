/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SerializeManager
	{
		// Fields
		private const string JSON_DIR_NAME = "/Gluon/";
		private FacilitySaveData unPackedSaveData;
		private bool isSaveDataUnpacked;
	
		// Constructors
		public SerializeManager();
	
		// Methods
		public static void SaveJsonFile(string fileName, string jsonStr);
		public static string LoadJsonFile(string fileName);
		public static string[] GetJsonFileNameList();
		public static void SaveMsgpackFile(string fileName, byte[] data);
		public static byte[] LoadMsgpackFile(string fileName);
		public void SerializeFacilities(string fileName);
		private byte[] SaveFacilityToMsgpack();
		public void LoadSerializedFacilities(string fileName);
		private void LoadFacilityFromMsgpack(byte[] data);
		public void RegisterPreLoadingFacilitiesFromSaveData(string fileName, bool async);
		public void RegisterLoadingFacilitiesFromSaveData(string fileName, bool async);
		private void RegisterLoadingFacilityFromMsgpack(byte[] data, bool async);
	}
}
