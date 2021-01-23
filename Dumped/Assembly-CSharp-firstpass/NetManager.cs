/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Timers;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class NetManager : IDisposable
{
	// Fields
	public static NetManager Instance;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation LogicallyConnected;
	[CompilerGenerated]
	private SysPost.StdMulticastDelegation LogicallyDisconnected;
	private long INTERVAL_KeepAlive;
	private long INTERVAL_CheckingConnectionStatus;
	private long INTERVAL_ReceivingData;
	private long _currentTimeInMilliseconds;
	private long _lastKeepAlive;
	private long _lastCheckingConnectionStatus;
	private long _lastReceivingData;
	private NetClient _client;
	private NetGuardTimer _guardTimer;
	private Timer _tickTimer;

	// Properties
	public bool IsConnected { get; }
	public string RemoteAddr { get; }
	public NetClient Client { get; }

	// Events
	public event SysPost.StdMulticastDelegation LogicallyConnected {
		add;
		remove;
	}
	public event SysPost.StdMulticastDelegation LogicallyDisconnected {
		add;
		remove;
	}

	// Constructors
	public NetManager();

	// Methods
	public void Dispose();
	public bool Connect(string addr);
	public void Disconnect();
	public void Send(UsCmd cmd);
	public void RegisterCmdHandler(eNetCmd cmd, UsCmdHandler handler);
	public void ExecuteCmd(string cmdText);
	private void OnConnected(object sender, EventArgs e);
	private void OnDisconnected(object sender, EventArgs e);
	private void OnGuardingTimeout(object sender, EventArgs e);
	private bool Handle_HandshakeResponse(eNetCmd cmd, UsCmd c);
	private bool Handle_KeepAliveResponse(eNetCmd cmd, UsCmd c);
	private bool Handle_ExecCommandResponse(eNetCmd cmd, UsCmd c);
	private void Tick();
	[CompilerGenerated]
	private void _.ctor_b__11_0(object sender, ElapsedEventArgs e);
}

