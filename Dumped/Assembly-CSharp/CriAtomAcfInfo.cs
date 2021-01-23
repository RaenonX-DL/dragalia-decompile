/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomAcfInfo
{
	// Fields
	public static AcfInfo acfInfo;

	// Nested types
	[Serializable]
	public class InfoBase
	{
		// Fields
		public string name;
		public int id;
		public string comment;

		// Constructors
		public InfoBase();
	}

	[Serializable]
	public class AcfInfo : InfoBase
	{
		// Fields
		public string acfPath;
		public string atomGuid;
		public string dspBusSetting;
		public List<string> aisacControlNameList;
		public string acfFilePath;

		// Constructors
		public AcfInfo(string n, int inId, string com, string inAcfPath, string _guid, string _dspBusSetting);
	}

	[Serializable]
	public class AcbInfo : InfoBase
	{
		// Fields
		public string acbPath;
		public string awbPath;
		public string atomGuid;
		public List<CueInfo> cueInfoList;

		// Constructors
		public AcbInfo(string n, int inId, string com, string inAcbPath, string inAwbPath, string _guid);
	}

	[Serializable]
	public class CueInfo : InfoBase
	{
		// Constructors
		public CueInfo(string n, int inId, string com);
	}

	// Constructors
	public CriAtomAcfInfo();
	static CriAtomAcfInfo();

	// Methods
	public static bool GetCueInfo(ref AcfInfo acfInfo, bool forceReload, string searchPath);
}

