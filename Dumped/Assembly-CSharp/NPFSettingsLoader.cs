/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class NPFSettingsLoader
{
	// Fields
	private const string npfSettingFileName = "npf";

	// Nested types
	private class NpfSettings
	{
		// Fields
		public string baasHost;
		public bool purchaseMock;
		public string clientId;
		public string accountHost;
		public string accountApiHost;
		public string pointProgramHost;
		public string basicAuthUser;
		public string basicAuthPass;
		public bool printLog;
		public bool debugLog;
		public string marketForSandbox;

		// Constructors
		public NpfSettings();
	}

	// Constructors
	public NPFSettingsLoader();

	// Methods
	public string GetAccountHost();
	public static string GetBaaSHost();
	public static bool IsPurchaseMock();
	private static NpfSettings GetNPFSetting();
}

