/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsLoadFileRequest : CriFsRequest
{
	// Fields
	[CompilerGenerated]
	private string _path_k__BackingField;
	[CompilerGenerated]
	private byte[] _bytes_k__BackingField;
	private Phase phase;
	private CriFsBinder refBinder;
	private CriFsBinder newBinder;
	private uint bindId;
	private CriFsLoader loader;
	private int readUnitSize;
	private long fileSize;

	// Properties
	public string path { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public byte[] bytes { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	private enum Phase
	{
		Stop = 0,
		Bind = 1,
		Load = 2,
		Done = 3,
		Error = 4
	}

	// Constructors
	public CriFsLoadFileRequest(CriFsBinder srcBinder, string path, DoneDelegate doneDelegate, int readUnitSize);

	// Methods
	protected override void Dispose(bool disposing);
	public override void Stop();
	public override void Update();
	private void UpdateBinder();
	private void UpdateLoader();
	private void OnError();
}

