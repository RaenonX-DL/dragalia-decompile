/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsMain : IDisposable
{
	// Fields
	public const int MAX_CONTENT_LEN = 1024;
	private long _currentTimeInMilliseconds;
	private long _tickNetLast;
	private long _tickNetInterval;
	private LogService _logServ;
	private utest _test;
	private bool _inGameGui;

	// Constructors
	public UsMain(bool LogRemotely, bool LogIntoFile, bool InGameGui);

	// Methods
	private void LogTarget_Remotely(object sender, LogEventArgs args);
	public void Update();
	public void Dispose();
	public void OnLevelWasLoaded();
	public void OnGUI();
}

