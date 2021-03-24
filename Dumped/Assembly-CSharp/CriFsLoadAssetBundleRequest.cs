/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsLoadAssetBundleRequest : CriFsRequest
{
	// Fields
	[CompilerGenerated]
	private string _path_k__BackingField;
	[CompilerGenerated]
	private AssetBundle _assetBundle_k__BackingField;
	private CriFsLoadFileRequest loadFileReq;
	private AssetBundleCreateRequest assetBundleReq;

	// Properties
	public string path { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public AssetBundle assetBundle { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Constructors
	public CriFsLoadAssetBundleRequest(CriFsBinder binder, string path, int readUnitSize);

	// Methods
	public override void Update();
	protected override void Dispose(bool disposing);
}

