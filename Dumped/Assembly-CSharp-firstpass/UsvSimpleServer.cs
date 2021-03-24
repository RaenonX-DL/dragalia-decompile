/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsvSimpleServer : IDisposable
{
	// Fields
	[CompilerGenerated]
	private UsvClientDisconnectedHandler ClientDisconnected;
	private TcpListener _tcpListener;
	private Dictionary<string, TcpClient> _tcpClients;
	private UsCmdParsing _cmdExec;
	private bool _isListening;
	private List<string> _toBeRemoved;
	private Dictionary<string, UsvClientConsoleCmdHandler> _clientConsoleCmdHandlers;

	// Properties
	public UsCmdParsing CmdExecutor { get; }
	public bool IsListening { get; }

	// Events
	public event UsvClientDisconnectedHandler ClientDisconnected {
		add;
		remove;
	}

	// Constructors
	public UsvSimpleServer();

	// Methods
	public void Dispose();
	public void Update();
	public TcpClient FindClient(string clientID);
	public void SendCommand(string clientID, UsCmd cmd);
	private void OnAcceptTcpClient(IAsyncResult asyncResult);
	private void NetLog(string text, params object[] args);
	private void NetLogClient(string clientID, string text, params object[] args);
	private bool NetHandle_Handshake(string clientID, eNetCmd cmd, UsCmd c);
	private bool NetHandle_KeepAlive(string clientID, eNetCmd cmd, UsCmd c);
	public void RegisterHandlerClass(Type handlerClassType, object handlerInst);
	private bool NetHandle_ExecCommand(string clientID, eNetCmd cmd, UsCmd c);
}

