/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsCmdParsing
{
	// Fields
	private Dictionary<eNetCmd, UsCmdHandler> m_handlers;
	private Dictionary<eNetCmd, UsClientCmdHandler> m_clientHandlers;

	// Constructors
	public UsCmdParsing();

	// Methods
	public void RegisterHandler(eNetCmd cmd, UsCmdHandler handler);
	public void RegisterClientHandler(eNetCmd cmd, UsClientCmdHandler handler);
	public UsCmdExecResult Execute(UsCmd c);
	public UsCmdExecResult ExecuteClient(string clientID, UsCmd c);
}

