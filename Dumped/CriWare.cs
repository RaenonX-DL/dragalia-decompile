using System.Runtime.InteropServices;
using UnityEngine;

public class CriWare
{
	public struct CpuUsage
	{
		public float last;

		public float average;

		public float peak;
	}

	private const string scriptVersionString = "2.31.36";

	private const int scriptVersionNumber = 36779520;

	public const bool supportsCriFsInstaller = true;

	public const bool supportsCriFsWebInstaller = true;

	public const string pluginName = "cri_ware_unity";

	public const CallingConvention pluginCallingConvention = CallingConvention.Winapi;

	private static GameObject _managerObject;

	public static string streamingAssetsPath => null;

	public static string installTargetPath => null;

	public static GameObject managerObject => null;

	public static bool IsStreamingAssetsPath(string path)
	{
		return default(bool);
	}

	public static string GetScriptVersionString()
	{
		return null;
	}

	public static int GetScriptVersionNumber()
	{
		return default(int);
	}

	public static int GetBinaryVersionNumber()
	{
		return default(int);
	}

	public static int GetRequiredBinaryVersionNumber()
	{
		return default(int);
	}

	public static bool CheckBinaryVersionCompatibility()
	{
		return default(bool);
	}

	public static uint GetFsMemoryUsage()
	{
		return default(uint);
	}

	public static uint GetAtomMemoryUsage()
	{
		return default(uint);
	}

	public static uint GetManaMemoryUsage()
	{
		return default(uint);
	}

	public static CpuUsage GetAtomCpuUsage()
	{
		return default(CpuUsage);
	}

	public static extern int CRIWARE85A17F35();

	public static extern void criWareUnity_SetRenderingEventOffsetForMana(int offset);
}
