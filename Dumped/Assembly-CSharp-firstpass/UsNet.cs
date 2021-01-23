/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsNet : IDisposable
{
	// Fields
	public static UsNet Instance;
	private TcpListener _tcpListener;
	private TcpClient _tcpClient;
	private readonly object _netLocker;
	private UsCmdParsing _cmdExec;
	private bool _isListening;

	// Properties
	public UsCmdParsing CmdExecutor { get; }
	public bool IsListening { get; }

	// Constructors
	public UsNet();

	// Methods
	~UsNet();
	public void Dispose();
	private void FreeResources();
	private void CloseTcpClient();
	public void Update();
	public void SendCommand(UsCmd cmd);
	private void OnAcceptTcpClient(IAsyncResult asyncResult);
	private void AddToLog(string text, params object[] args);
}

