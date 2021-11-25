public static class CriAtomExPlaybackDebug
{
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value)
	{
		return default(bool);
	}

	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value)
	{
		return default(bool);
	}

	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value)
	{
		return default(bool);
	}

	public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value)
	{
		return default(bool);
	}

	public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value)
	{
		return default(bool);
	}

	private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value);

	private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value);

	private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value);

	private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value);

	private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value);
}
