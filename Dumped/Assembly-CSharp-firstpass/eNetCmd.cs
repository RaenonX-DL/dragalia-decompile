/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public enum eNetCmd
{
	None = 0,
	CL_CmdBegin = 1000,
	CL_Handshake = 1001,
	CL_KeepAlive = 1002,
	CL_ExecCommand = 1003,
	CL_RequestFrameData = 1004,
	CL_FrameV2_RequestMeshes = 1005,
	CL_FrameV2_RequestNames = 1006,
	CL_QuerySwitches = 1007,
	CL_QuerySliders = 1008,
	CL_RequestStackSummary = 1009,
	CL_StartAnalysePixels = 1010,
	CL_RequestStackData = 1011,
	CL_CmdEnd = 1012,
	SV_CmdBegin = 2000,
	SV_HandshakeResponse = 2001,
	SV_KeepAliveResponse = 2002,
	SV_ExecCommandResponse = 2003,
	SV_FrameDataV2 = 2004,
	SV_FrameDataV2_Meshes = 2005,
	SV_FrameDataV2_Names = 2006,
	SV_FrameData_Material = 2007,
	SV_FrameData_Texture = 2008,
	SV_FrameDataEnd = 2009,
	SV_App_Logging = 2010,
	SV_QuerySwitchesResponse = 2011,
	SV_QuerySlidersResponse = 2012,
	SV_QueryStacksResponse = 2013,
	SV_VarTracerJsonParameter = 2014,
	SV_StressTestNames = 2015,
	SV_StressTestResult = 2016,
	SV_StartAnalysePixels = 2017,
	SV_CmdEnd = 2018,
	SV_SendLuaProfilerMsg = 2019,
	SV_StartLuaProfilerMsg = 2020
}

