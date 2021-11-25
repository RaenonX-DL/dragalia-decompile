using System;

[Serializable]
public class CriAtomCueSheet
{
	public string name;

	public string acbFile;

	public string awbFile;

	public CriAtomExAcb acb;

	public CriAtomExAcbLoader.Status loaderStatus;

	public bool IsLoading => default(bool);

	public bool IsError => default(bool);
}
