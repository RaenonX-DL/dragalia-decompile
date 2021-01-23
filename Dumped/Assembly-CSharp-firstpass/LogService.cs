/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class LogService : IDisposable
{
	// Fields
	[CompilerGenerated]
	private LogTargetHandler LogTargets;
	public static int UserDefinedMemBufSize;
	private string _logPath;
	private StreamWriter _logWriter;
	private ushort _seqID;
	private int _assertCount;
	private int _errorCount;
	private int _exceptionCount;
	private bool _disposed;
	private bool _useMemBuf;
	private LogBuffer _memBuf;
	private string _lastWrittenContent;
	private LogType _lastWrittenType;
	private int _foldedCount;
	private bool _reentranceGuard;
	[CompilerGenerated]
	private static string _LastLogFile_k__BackingField;

	// Properties
	public bool UseMemBuf { get; set; }
	public static string LastLogFile { [CompilerGenerated] get; [CompilerGenerated] set; }

	// Events
	public event LogTargetHandler LogTargets {
		add;
		remove;
	}

	// Constructors
	public LogService(bool logIntoFile, int oldLogsKeptDays, bool useMemBuf);
	static LogService();

	// Methods
	public void Dispose();
	public void WriteLog(string content, LogType type);
	public void FlushLogWriting();
	private void CleanupLogsOlderThan(int days);
	private void RegisterCallback();
	private void WriteTrace(string content);
	private void OnLogReceived(string condition, string stackTrace, LogType type);
	private void FlushMemBuffer();
	private void FlushFoldedMessage();
}

