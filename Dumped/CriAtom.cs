using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[AddComponentMenu("CRIWARE/CRI Atom")]
public class CriAtom : MonoBehaviour
{
	public string acfFile;

	private bool acfIsLoading;

	public CriAtomCueSheet[] cueSheets;

	public string dspBusSetting;

	public bool dontDestroyOnLoad;

	private static CriAtomExSequencer.EventCbFunc eventUserCbFunc;

	private static CriAtomExBeatSync.CbFunc beatsyncUserCbFunc;

	public bool dontRemoveExistsCueSheet;

	private static CriAtom instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool CueSheetsAreLoading => default(bool);

	public static void AttachDspBusSetting(string settingName)
	{
	}

	public static void DetachDspBusSetting()
	{
	}

	public static CriAtomCueSheet GetCueSheet(string name)
	{
		return null;
	}

	public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder)
	{
		return null;
	}

	public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, [Optional] CriFsBinder binder, bool loadAwbOnMemory = false)
	{
		return null;
	}

	public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder)
	{
		return null;
	}

	public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, [Optional] CriFsBinder awbBinder, bool loadAwbOnMemory = false)
	{
		return null;
	}

	public static void RemoveCueSheet(string name)
	{
	}

	public static CriAtomExAcb GetAcb(string cueSheetName)
	{
		return null;
	}

	public static void SetCategoryVolume(string name, float volume)
	{
	}

	public static void SetCategoryVolume(int id, float volume)
	{
	}

	public static float GetCategoryVolume(string name)
	{
		return default(float);
	}

	public static float GetCategoryVolume(int id)
	{
		return default(float);
	}

	public static void SetBusAnalyzer(string busName, bool sw)
	{
	}

	public static void SetBusAnalyzer(bool sw)
	{
	}

	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName)
	{
		return default(CriAtomExAsr.BusAnalyzerInfo);
	}

	[Obsolete]
	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId)
	{
		return default(CriAtomExAsr.BusAnalyzerInfo);
	}

	public void Setup()
	{
	}

	public void Shutdown()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public CriAtomCueSheet GetCueSheetInternal(string name)
	{
		return null;
	}

	public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder)
	{
		return null;
	}

	public void RemoveCueSheetInternal(string name)
	{
	}

	private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet)
	{
	}

	private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile)
	{
		return null;
	}

	private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile)
	{
		return null;
	}

	private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory)
	{
	}

	private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory)
	{
		return null;
	}

	private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory)
	{
	}

	private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory)
	{
		return null;
	}

	public static void SequenceEventCallbackFromNative(string eventString)
	{
	}

	public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info)
	{
	}

	public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator)
	{
	}

	public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func)
	{
	}
}
