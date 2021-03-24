/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[CreateAssetMenu]
public class NPFServerSettingTable : ScriptableObject
{
	// Fields
	public List<NPFServerSetting> settings;
	private static NPFServerSettingTable _instance;

	// Properties
	public static NPFServerSettingTable instance { get; }

	// Nested types
	[Serializable]
	public class NPFServerSetting
	{
		// Fields
		public string name;
		public string baas;
		public string appId;
		public string secret;
		public string bundleid;

		// Constructors
		public NPFServerSetting();
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0
	{
		// Fields
		public string name;

		// Constructors
		public __c__DisplayClass5_0();

		// Methods
		internal bool _GetNPFSetting_b__0(NPFServerSetting s);
	}

	// Constructors
	public NPFServerSettingTable();
	static NPFServerSettingTable();

	// Methods
	public NPFServerSetting GetNPFSetting(string name);
}

