/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class ResourceTracker : IDisposable
{
	// Fields
	public static ResourceTracker Instance;
	private bool _enableTracking;
	private StreamWriter _logWriter;
	private int _reqSeq;
	private Dictionary<string, string> _shaderPropertyDict;
	private Dictionary<string, List<stackParamater>> _stackUnavailableDict;
	private Dictionary<object, ResourceRequestInfo> InProgressAsyncObjects;
	private Dictionary<int, ResourceRequestInfo> TrackedAllocInfo;
	private Dictionary<int, int> TrackedGameObjects;
	private Dictionary<int, int> TrackedMemObjects;
	private Dictionary<int, string> Stacktraces;

	// Properties
	public bool EnableTracking { get; }
	public Dictionary<string, string> ShaderPropertyDict { get; }

	// Nested types
	private class stackParamater
	{
		// Fields
		private int instanceID;
		private int size;

		// Properties
		public int InstanceID { get; set; }
		public int Size { get; set; }

		// Constructors
		public stackParamater();
	}

	// Constructors
	public ResourceTracker(bool enableTracking);

	// Methods
	private void readShaderPropertyJson();
	public void Open();
	public void Close();
	public void Dispose();
	public void TrackSyncRequest(UnityEngine.Object spawned, string path);
	public void TrackResourcesDotLoad(UnityEngine.Object loaded, string path);
	public void TrackAsyncRequest(object handle, string path);
	public void TrackAsyncDone(object handle, UnityEngine.Object target);
	public void TrackSceneLoaded(string sceneName);
	public void TrackObjectInstantiation(UnityEngine.Object src, UnityEngine.Object instantiated);
	public ResourceRequestInfo GetAllocInfo(int instID);
	public string GetStackTrace(ResourceRequestInfo req);
	private ResourceRequestInfo NewRequest(string path, StackFrame sf);
	private void ExtractObjectResources(UnityEngine.Object obj, int reqSeqID);
	public bool NetHandle_RequestStackSummary(eNetCmd cmd, UsCmd c);
	public List<Texture2D> GetTexture2DObjsFromMaterial(Material mat);
	public bool NetHandle_RequestStackData(eNetCmd cmd, UsCmd c);
	private void TrackRequestWithObject(ResourceRequestInfo req, UnityEngine.Object obj);
}

