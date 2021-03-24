/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExAcfDebug
{
	// Nested types
	public struct CategoryInfo
	{
		// Fields
		public uint groupNo;
		public uint id;
		public string name;
		public uint numCueLimits;
		public float volume;
	}

	public struct DspBusInfo
	{
		// Fields
		public string name;
		public float volume;
		public float pan3dVolume;
		public float pan3dAngle;
		public float pan3dDistance;
		public ushort[] fxIndexes;
		public ushort[] busLinkIndexes;
		public ushort busNo;
		public byte numFxes;
		public byte numBusLinks;
	}

	public struct AisacControlInfo
	{
		// Fields
		public string name;
		public uint id;
	}

	public enum AisacType
	{
		Normal = 0,
		AutoModulation = 1
	}

	public struct GlobalAisacInfo
	{
		// Fields
		public string name;
		public ushort index;
		public ushort numGraphs;
		public AisacType type;
		public float randomRange;
		public ushort controlId;
	}

	public struct SelectorInfo
	{
		// Fields
		public string name;
		public ushort index;
		public ushort numLabels;
		public ushort globalLabelIndex;
	}

	public struct SelectorLabelInfo
	{
		// Fields
		public string selectorName;
		public string labelName;
	}

	private struct CategoryInfoForMarshaling
	{
		// Fields
		public uint groupNo;
		public uint id;
		public IntPtr namePtr;
		public uint numCueLimits;
		public float volume;

		// Methods
		public void Convert(out CategoryInfo x);
	}

	private struct DspBusInfoForMarshaling
	{
		// Fields
		public IntPtr namePtr;
		public float volume;
		public float pan3dVolume;
		public float pan3dAngle;
		public float pan3dDistance;
		public ushort[] fxIndexes;
		public ushort[] busLinkIndexes;
		public ushort busNo;
		public byte numFxes;
		public byte numBusLinks;

		// Methods
		public void Convert(out DspBusInfo x);
	}

	private struct AisacControlInfoForMarshaling
	{
		// Fields
		public IntPtr namePtr;
		public uint id;

		// Methods
		public void Convert(out AisacControlInfo x);
	}

	private struct GlobalAisacInfoForMarshaling
	{
		// Fields
		public IntPtr namePtr;
		public ushort index;
		public ushort numGraphs;
		public uint type;
		public float randomRange;
		public ushort controlId;
		public ushort dummy;

		// Methods
		public void Convert(out GlobalAisacInfo x);
	}

	private struct SelectorInfoForMarshaling
	{
		// Fields
		public IntPtr namePtr;
		public ushort index;
		public ushort numLabels;
		public ushort globalLabelIndex;

		// Methods
		public void Convert(out SelectorInfo x);
	}

	private struct SelectorLabelInfoForMarshaling
	{
		// Fields
		public IntPtr selectorNamePtr;
		public IntPtr labelNamePtr;

		// Methods
		public void Convert(out SelectorLabelInfo x);
	}

	// Methods
	public static int GetNumCategories();
	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo);
	public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo);
	public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo);
	public static int GetNumBuses();
	public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo);
	public static int GetNumAisacControls();
	public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info);
	public static uint GetAisacControlIdByName(string name);
	public static string GetAisacControlNameById(uint id);
	public static int GetNumGlobalAisacs();
	public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info);
	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info);
	public static int GetNumSelectors();
	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info);
	public static bool GetSelectorInfoByName(string name, out SelectorInfo info);
	public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo);
	private static extern int criAtomExAcf_GetNumCategories();
	private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CategoryInfoForMarshaling categoryInfo);
	private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CategoryInfoForMarshaling categoryInfo);
	private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CategoryInfoForMarshaling categoryInfo);
	private static extern int criAtomExAcf_GetNumBuses();
	private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out DspBusInfoForMarshaling dspBusInfo);
	private static extern int criAtomExAcf_GetNumAisacControls();
	private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out AisacControlInfoForMarshaling info);
	private static extern uint criAtomExAcf_GetAisacControlIdByName(string name);
	private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id);
	private static extern int criAtomExAcf_GetNumGlobalAisacs();
	private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out GlobalAisacInfoForMarshaling info);
	private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out GlobalAisacInfoForMarshaling info);
	private static extern int criAtomExAcf_GetNumSelectors();
	private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out SelectorInfoForMarshaling info);
	private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out SelectorInfoForMarshaling info);
	private static extern int criAtomExAcf_GetSelectorLabelInfo(ref SelectorInfoForMarshaling info, ushort labelIndex, out SelectorLabelInfoForMarshaling label_info);
}

