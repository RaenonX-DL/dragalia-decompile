/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class NetClient : IDisposable
{
	// Fields
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation Connected;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation Disconnected;
	private string _host;
	private int _port;
	private TcpClient _tcpClient;
	private UsCmdParsing _cmdParser;

	// Properties
	public bool IsConnected { get; }
	public string RemoteAddr { get; }

	// Events
	public event SysPost.StdMulticastDelegation Connected {
		add;
		remove;
	}
	public event SysPost.StdMulticastDelegation Disconnected {
		add;
		remove;
	}

	// Constructors
	public NetClient();

	// Methods
	public void Connect(string host, int port);
	public void Disconnect();
	public void RegisterCmdHandler(eNetCmd cmd, UsCmdHandler handler);
	public void Tick_CheckConnectionStatus();
	public void Tick_ReceivingData();
	public void Dispose();
	public void SendPacket(UsCmd cmd);
	private void OnConnect(IAsyncResult asyncResult);
	private void DisconnectOnError(string info, Exception ex);
}

