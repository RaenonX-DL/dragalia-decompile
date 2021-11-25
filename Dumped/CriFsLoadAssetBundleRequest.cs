using System.Runtime.CompilerServices;
using UnityEngine;

public class CriFsLoadAssetBundleRequest : CriFsRequest
{
	private CriFsLoadFileRequest loadFileReq;

	private AssetBundleCreateRequest assetBundleReq;

	public string path
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public AssetBundle assetBundle
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize)
	{
	}

	public override void Update()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
