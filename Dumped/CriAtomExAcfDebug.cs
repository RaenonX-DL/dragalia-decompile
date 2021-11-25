using System;

public static class CriAtomExAcfDebug
{
	public struct CategoryInfo
	{
		public uint groupNo;

		public uint id;

		public string name;

		public uint numCueLimits;

		public float volume;
	}

	public struct DspBusInfo
	{
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
		public string name;

		public uint id;
	}

	public enum AisacType
	{
		Normal,
		AutoModulation
	}

	public struct GlobalAisacInfo
	{
		public string name;

		public ushort index;

		public ushort numGraphs;

		public AisacType type;

		public float randomRange;

		public ushort controlId;
	}

	public struct SelectorInfo
	{
		public string name;

		public ushort index;

		public ushort numLabels;

		public ushort globalLabelIndex;
	}

	public struct SelectorLabelInfo
	{
		public string selectorName;

		public string labelName;
	}

	private struct CategoryInfoForMarshaling
	{
		public uint groupNo;

		public uint id;

		public IntPtr namePtr;

		public uint numCueLimits;

		public float volume;

		public void Convert(out CategoryInfo x)
		{
		}
	}

	private struct DspBusInfoForMarshaling
	{
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

		public void Convert(out DspBusInfo x)
		{
		}
	}

	private struct AisacControlInfoForMarshaling
	{
		public IntPtr namePtr;

		public uint id;

		public void Convert(out AisacControlInfo x)
		{
		}
	}

	private struct GlobalAisacInfoForMarshaling
	{
		public IntPtr namePtr;

		public ushort index;

		public ushort numGraphs;

		public uint type;

		public float randomRange;

		public ushort controlId;

		public ushort dummy;

		public void Convert(out GlobalAisacInfo x)
		{
		}
	}

	private struct SelectorInfoForMarshaling
	{
		public IntPtr namePtr;

		public ushort index;

		public ushort numLabels;

		public ushort globalLabelIndex;

		public void Convert(out SelectorInfo x)
		{
		}
	}

	private struct SelectorLabelInfoForMarshaling
	{
		public IntPtr selectorNamePtr;

		public IntPtr labelNamePtr;

		public void Convert(out SelectorLabelInfo x)
		{
		}
	}

	public static int GetNumCategories()
	{
		return default(int);
	}

	public static bool GetCategoryInfoByIndex(ushort index, out CategoryInfo categoryInfo)
	{
		return default(bool);
	}

	public static bool GetCategoryInfoByName(string name, out CategoryInfo categoryInfo)
	{
		return default(bool);
	}

	public static bool GetCategoryInfoById(uint id, out CategoryInfo categoryInfo)
	{
		return default(bool);
	}

	public static int GetNumBuses()
	{
		return default(int);
	}

	public static bool GetDspBusInformation(ushort index, out DspBusInfo dspBusInfo)
	{
		return default(bool);
	}

	public static int GetNumAisacControls()
	{
		return default(int);
	}

	public static bool GetAisacControlInfo(ushort index, out AisacControlInfo info)
	{
		return default(bool);
	}

	public static uint GetAisacControlIdByName(string name)
	{
		return default(uint);
	}

	public static string GetAisacControlNameById(uint id)
	{
		return null;
	}

	public static int GetNumGlobalAisacs()
	{
		return default(int);
	}

	public static bool GetGlobalAisacInfo(ushort index, out GlobalAisacInfo info)
	{
		return default(bool);
	}

	public static bool GetGlobalAisacInfoByName(string name, out GlobalAisacInfo info)
	{
		return default(bool);
	}

	public static int GetNumSelectors()
	{
		return default(int);
	}

	public static bool GetSelectorInfoByIndex(ushort index, out SelectorInfo info)
	{
		return default(bool);
	}

	public static bool GetSelectorInfoByName(string name, out SelectorInfo info)
	{
		return default(bool);
	}

	public static bool GetSelectorLabelInfo(ref SelectorInfo selectorInfo, ushort index, out SelectorLabelInfo labelInfo)
	{
		return default(bool);
	}

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
