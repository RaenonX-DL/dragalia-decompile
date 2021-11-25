using System;
using System.Collections.Generic;

public class CriAtomAcfInfo
{
	[Serializable]
	public class InfoBase
	{
		public string name;

		public int id;

		public string comment;
	}

	[Serializable]
	public class AcfInfo : InfoBase
	{
		public string acfPath;

		public string atomGuid;

		public string dspBusSetting;

		public List<string> aisacControlNameList;

		public string acfFilePath;

		public AcfInfo(string n, int inId, string com, string inAcfPath, string _guid, string _dspBusSetting)
		{
		}
	}

	[Serializable]
	public class AcbInfo : InfoBase
	{
		public string acbPath;

		public string awbPath;

		public string atomGuid;

		public List<CueInfo> cueInfoList;

		public AcbInfo(string n, int inId, string com, string inAcbPath, string inAwbPath, string _guid)
		{
		}
	}

	[Serializable]
	public class CueInfo : InfoBase
	{
		public CueInfo(string n, int inId, string com)
		{
		}
	}

	public static AcfInfo acfInfo;

	public static bool GetCueInfo(ref AcfInfo acfInfo, bool forceReload, string searchPath)
	{
		return default(bool);
	}
}
