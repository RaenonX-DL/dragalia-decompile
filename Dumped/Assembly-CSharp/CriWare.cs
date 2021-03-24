/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriWare
{
	// Fields
	private const string scriptVersionString = "2.31.36";
	private const int scriptVersionNumber = 36779520;
	public const bool supportsCriFsInstaller = true;
	public const bool supportsCriFsWebInstaller = true;
	public const string pluginName = "cri_ware_unity";
	public const CallingConvention pluginCallingConvention = CallingConvention.Winapi;
	private static GameObject _managerObject;

	// Properties
	public static string streamingAssetsPath { get; }
	public static string installTargetPath { get; }
	public static GameObject managerObject { get; }

	// Nested types
	public struct CpuUsage
	{
		// Fields
		public float last;
		public float average;
		public float peak;
	}

	// Constructors
	public CriWare();
	static CriWare();

	// Methods
	public static bool IsStreamingAssetsPath(string path);
	public static string GetScriptVersionString();
	public static int GetScriptVersionNumber();
	public static int GetBinaryVersionNumber();
	public static int GetRequiredBinaryVersionNumber();
	public static bool CheckBinaryVersionCompatibility();
	public static uint GetFsMemoryUsage();
	public static uint GetAtomMemoryUsage();
	public static uint GetManaMemoryUsage();
	public static CpuUsage GetAtomCpuUsage();
	public static extern int CRIWARE85A17F35();
	public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset);
}

