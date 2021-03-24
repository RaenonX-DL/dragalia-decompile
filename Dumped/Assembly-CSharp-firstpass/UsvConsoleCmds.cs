/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsvConsoleCmds
{
	// Fields
	public static UsvConsoleCmds Instance;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation QueryEffectList;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation RunEffectStressTest;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation StartAnalyzePixel;

	// Events
	public event SysPost.StdMulticastDelegation QueryEffectList {
		add;
		remove;
	}
	public event SysPost.StdMulticastDelegation RunEffectStressTest {
		add;
		remove;
	}
	public event SysPost.StdMulticastDelegation StartAnalyzePixel {
		add;
		remove;
	}

	// Nested types
	public class AnalysePixelsArgs : EventArgs
	{
		// Fields
		public bool bRefresh;

		// Constructors
		public AnalysePixelsArgs(bool b);
	}

	public class UsEffectStressTestEventArgs : EventArgs
	{
		// Fields
		public string _effectName;
		public int _effectCount;

		// Constructors
		public UsEffectStressTestEventArgs(string effectName, int effectCount);
	}

	// Constructors
	public UsvConsoleCmds();

	// Methods
	[ConsoleHandler]
	public bool ShowMesh(string[] args);
	[ConsoleHandler]
	public bool HideMesh(string[] args);
	private bool SetMeshVisible(string strInstID, bool visible);
	[ConsoleHandler]
	public bool PrintTestLogs(string[] args);
	[ConsoleHandler]
	public bool ToggleSwitch(string[] args);
	[ConsoleHandler]
	public bool SlideChanged(string[] args);
	[ConsoleHandler]
	public bool FlyTo(string[] args);
	[ConsoleHandler]
	public bool StartAnalysePixelsTriggered(string[] args);
	[ConsoleHandler]
	public bool QueryEffectListTriggered(string[] args);
	[ConsoleHandler]
	public bool EffectStressTestTriggered(string[] args);
}

