/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriAtom : MonoBehaviour
{
	// Fields
	public string acfFile;
	private bool acfIsLoading;
	public CriAtomCueSheet[] cueSheets;
	public string dspBusSetting;
	public bool dontDestroyOnLoad;
	private static CriAtomExSequencer.EventCbFunc eventUserCbFunc;
	private static CriAtomExBeatSync.CbFunc beatsyncUserCbFunc;
	[CompilerGenerated]
	private static CriAtom _instance_k__BackingField;
	public bool dontRemoveExistsCueSheet;

	// Properties
	private static CriAtom instance { [CompilerGenerated] get; [CompilerGenerated] set; }
	public static bool CueSheetsAreLoading { get; }

	// Nested types
	[CompilerGenerated]
	private sealed class __c__DisplayClass40_0
	{
		// Fields
		public int i;
		public CriAtom __4__this;

		// Constructors
		public __c__DisplayClass40_0();

		// Methods
		internal bool _MargeCueSheet_b__0(CriAtomCueSheet sheet);
	}

	[CompilerGenerated]
	private sealed class _LoadAcbFileCoroutine_d__44 : IEnumerator<object>
	{
		// Fields
		private int __1__state;
		private object __2__current;
		public CriAtomCueSheet cueSheet;
		public CriFsBinder binder;
		public string acbPath;
		public string awbPath;
		public CriAtom __4__this;
		public bool loadAwbOnMemory;
		private CriAtomExAcbLoader _asyncLoader_5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
		object IEnumerator.Current { [DebuggerHidden] get; }

		// Constructors
		[DebuggerHidden]
		public _LoadAcbFileCoroutine_d__44(int __1__state);

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose();
		private bool MoveNext();
		private void __m__Finally1();
		[DebuggerHidden]
		void IEnumerator.Reset();
	}

	[CompilerGenerated]
	private sealed class _LoadAcbDataCoroutine_d__46 : IEnumerator<object>
	{
		// Fields
		private int __1__state;
		private object __2__current;
		public CriAtomCueSheet cueSheet;
		public string awbPath;
		public CriFsBinder awbBinder;
		public CriAtom __4__this;
		public byte[] acbData;
		public bool loadAwbOnMemory;
		private CriAtomExAcbLoader _asyncLoader_5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
		object IEnumerator.Current { [DebuggerHidden] get; }

		// Constructors
		[DebuggerHidden]
		public _LoadAcbDataCoroutine_d__46(int __1__state);

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose();
		private bool MoveNext();
		private void __m__Finally1();
		[DebuggerHidden]
		void IEnumerator.Reset();
	}

	// Constructors
	public CriAtom();
	static CriAtom();

	// Methods
	public static void AttachDspBusSetting(string settingName);
	public static void DetachDspBusSetting();
	public static CriAtomCueSheet GetCueSheet(string name);
	public static CriAtomCueSheet AddCueSheet(string name, string acbFile, string awbFile, CriFsBinder binder = null);
	public static CriAtomCueSheet AddCueSheetAsync(string name, string acbFile, string awbFile, CriFsBinder binder = null, bool loadAwbOnMemory = false);
	public static CriAtomCueSheet AddCueSheet(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null);
	public static CriAtomCueSheet AddCueSheetAsync(string name, byte[] acbData, string awbFile, CriFsBinder awbBinder = null, bool loadAwbOnMemory = false);
	public static void RemoveCueSheet(string name);
	public static CriAtomExAcb GetAcb(string cueSheetName);
	public static void SetCategoryVolume(string name, float volume);
	public static void SetCategoryVolume(int id, float volume);
	public static float GetCategoryVolume(string name);
	public static float GetCategoryVolume(int id);
	public static void SetBusAnalyzer(string busName, bool sw);
	public static void SetBusAnalyzer(bool sw);
	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(string busName);
	[Obsolete]
	public static CriAtomExAsr.BusAnalyzerInfo GetBusAnalyzerInfo(int busId);
	public void Setup();
	public void Shutdown();
	private void Awake();
	private void OnEnable();
	private void OnDestroy();
	private void Update();
	public CriAtomCueSheet GetCueSheetInternal(string name);
	public CriAtomCueSheet AddCueSheetInternal(string name, string acbFile, string awbFile, CriFsBinder binder);
	public void RemoveCueSheetInternal(string name);
	private void MargeCueSheet(CriAtomCueSheet[] newCueSheets, bool newDontRemoveExistsCueSheet);
	private CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbFile, string awbFile);
	private CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder binder, string awbFile);
	private void LoadAcbFileAsync(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbFile, string awbFile, bool loadAwbOnMemory);
	[IteratorStateMachine]
	private IEnumerator LoadAcbFileCoroutine(CriAtomCueSheet cueSheet, CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory);
	private void LoadAcbDataAsync(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbFile, bool loadAwbOnMemory);
	[IteratorStateMachine]
	private IEnumerator LoadAcbDataCoroutine(CriAtomCueSheet cueSheet, byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory);
	[MonoPInvokeCallback]
	public static void SequenceEventCallbackFromNative(string eventString);
	[MonoPInvokeCallback]
	public static void BeatSyncCallbackFromNative(ref CriAtomExBeatSync.Info info);
	public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator);
	public static void SetBeatSyncCallback(CriAtomExBeatSync.CbFunc func);
}

