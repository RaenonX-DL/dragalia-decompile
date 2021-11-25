using System;
using System.Runtime.InteropServices;

public class CriAtomExAcb : CriDisposable
{
	private IntPtr handle;

	private byte[] data;

	private GCHandle dataHandle;

	public IntPtr nativeHandle => default(IntPtr);

	public bool isAvailable => default(bool);

	public static CriAtomExAcb LoadAcbFile(CriFsBinder binder, string acbPath, string awbPath)
	{
		return null;
	}

	public static CriAtomExAcb LoadAcbData(byte[] acbData, CriFsBinder awbBinder, string awbPath)
	{
		return null;
	}

	public override void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public bool Exists(string cueName)
	{
		return default(bool);
	}

	public bool Exists(int cueId)
	{
		return default(bool);
	}

	public bool GetCueInfo(string cueName, out CriAtomEx.CueInfo info)
	{
		return default(bool);
	}

	public bool GetCueInfo(int cueId, out CriAtomEx.CueInfo info)
	{
		return default(bool);
	}

	public bool GetCueInfoByIndex(int index, out CriAtomEx.CueInfo info)
	{
		return default(bool);
	}

	public CriAtomEx.CueInfo[] GetCueInfoList()
	{
		return null;
	}

	public bool GetWaveFormInfo(string cueName, out CriAtomEx.WaveformInfo info)
	{
		return default(bool);
	}

	public bool GetWaveFormInfo(int cueId, out CriAtomEx.WaveformInfo info)
	{
		return default(bool);
	}

	public int GetNumCuePlaying(string name)
	{
		return default(int);
	}

	public int GetNumCuePlaying(int id)
	{
		return default(int);
	}

	public int GetBlockIndex(string cueName, string blockName)
	{
		return default(int);
	}

	public int GetBlockIndex(int cueId, string blockName)
	{
		return default(int);
	}

	public int GetNumUsableAisacControls(string cueName)
	{
		return default(int);
	}

	public int GetNumUsableAisacControls(int cueId)
	{
		return default(int);
	}

	public bool GetUsableAisacControl(string cueName, int index, out CriAtomEx.AisacControlInfo info)
	{
		return default(bool);
	}

	public bool GetUsableAisacControl(int cueId, int index, out CriAtomEx.AisacControlInfo info)
	{
		return default(bool);
	}

	public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(string cueName)
	{
		return null;
	}

	public CriAtomEx.AisacControlInfo[] GetUsableAisacControlList(int cueId)
	{
		return null;
	}

	public void ResetCueTypeState(string cueName)
	{
	}

	public void ResetCueTypeState(int cueId)
	{
	}

	public void AttachAwbFile(CriFsBinder awb_binder, string awb_path, string awb_name)
	{
	}

	public void DetachAwbFile(string awb_name)
	{
	}

	public float GetLoadProgress()
	{
		return default(float);
	}

	public void Decrypt(ulong key, ulong nonce)
	{
	}

	internal CriAtomExAcb(IntPtr handle, byte[] data)
	{
	}

	~CriAtomExAcb()
	{
	}

	private static extern IntPtr criAtomExAcb_LoadAcbFile(IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);

	private static extern IntPtr criAtomExAcb_LoadAcbData(byte[] acb_data, int acb_data_size, IntPtr awb_binder, string awb_path, IntPtr work, int work_size);

	private static extern void criAtomExAcb_Release(IntPtr acb_hn);

	private static extern int criAtomExAcb_GetNumCues(IntPtr acb_hn);

	private static extern bool criAtomExAcb_ExistsId(IntPtr acb_hn, int id);

	private static extern bool criAtomExAcb_ExistsName(IntPtr acb_hn, string name);

	private static extern int criAtomExAcb_GetNumUsableAisacControlsById(IntPtr acb_hn, int id);

	private static extern int criAtomExAcb_GetNumUsableAisacControlsByName(IntPtr acb_hn, string name);

	private static extern bool criAtomExAcb_GetUsableAisacControlById(IntPtr acb_hn, int id, ushort index, IntPtr info);

	private static extern bool criAtomExAcb_GetUsableAisacControlByName(IntPtr acb_hn, string name, ushort index, IntPtr info);

	private static extern bool criAtomExAcb_GetWaveformInfoById(IntPtr acb_hn, int id, IntPtr waveform_info);

	private static extern bool criAtomExAcb_GetWaveformInfoByName(IntPtr acb_hn, string name, IntPtr waveform_info);

	private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info);

	private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info);

	private static extern bool criAtomExAcb_GetCueInfoByIndex(IntPtr acb_hn, int index, IntPtr info);

	private static extern int criAtomExAcb_GetNumCuePlayingCountByName(IntPtr acb_hn, string name);

	private static extern int criAtomExAcb_GetNumCuePlayingCountById(IntPtr acb_hn, int id);

	private static extern int criAtomExAcb_GetBlockIndexById(IntPtr acb_hn, int id, string block_name);

	private static extern int criAtomExAcb_GetBlockIndexByName(IntPtr acb_hn, string name, string block_name);

	private static extern void criAtomExAcb_ResetCueTypeStateByName(IntPtr acb_hn, string name);

	private static extern void criAtomExAcb_ResetCueTypeStateById(IntPtr acb_hn, int id);

	private static extern void criAtomExAcb_AttachAwbFile(IntPtr acb_hn, IntPtr awb_binder, string awb_path, string awb_name, IntPtr work, int work_size);

	private static extern void criAtomExAcb_DetachAwbFile(IntPtr acb_hn, string awb_name);
}
