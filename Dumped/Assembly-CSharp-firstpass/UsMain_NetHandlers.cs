/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class UsMain_NetHandlers
{
	// Fields
	public static UsMain_NetHandlers Instance;
	private int SLICE_COUNT;

	// Constructors
	public UsMain_NetHandlers(UsCmdParsing exec);

	// Methods
	private bool NetHandle_Handshake(eNetCmd cmd, UsCmd c);
	private bool NetHandle_KeepAlive(eNetCmd cmd, UsCmd c);
	private bool NetHandle_ExecCommand(eNetCmd cmd, UsCmd c);
	private bool NetHandle_RequestFrameData(eNetCmd cmd, UsCmd c);
	private bool NetHandle_FrameV2_RequestMeshes(eNetCmd cmd, UsCmd c);
	private bool NetHandle_FrameV2_RequestNames(eNetCmd cmd, UsCmd c);
	private bool NetHandle_QuerySwitches(eNetCmd cmd, UsCmd c);
	private bool NetHandle_QuerySliders(eNetCmd cmd, UsCmd c);
}

