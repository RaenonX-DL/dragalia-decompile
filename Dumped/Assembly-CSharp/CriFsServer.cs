/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsServer : MonoBehaviour
{
	// Fields
	private static CriFsServer _instance;
	private List<CriFsRequest> requestList;
	[CompilerGenerated]
	private int _installBufferSize_k__BackingField;

	// Properties
	public static CriFsServer instance { get; }
	public int installBufferSize { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	[Serializable]
	[CompilerGenerated]
	private sealed class __c
	{
		// Fields
		public static readonly __c __9;
		public static Predicate<CriFsRequest> __9__12_0;

		// Constructors
		static __c();
		public __c();

		// Methods
		internal bool _Update_b__12_0(CriFsRequest request);
	}

	// Constructors
	public CriFsServer();
	static CriFsServer();

	// Methods
	public static void CreateInstance();
	public static void DestroyInstance();
	private void Awake();
	private void OnDestroy();
	private void Update();
	public void AddRequest(CriFsRequest request);
	public CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize);
	public CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize);
	public CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate);
	public CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDelegate);
	public CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string path);
	public CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string path);
	public CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string path);
}

