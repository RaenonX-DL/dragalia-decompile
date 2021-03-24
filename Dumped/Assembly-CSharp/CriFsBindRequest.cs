/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsBindRequest : CriFsRequest
{
	// Fields
	[CompilerGenerated]
	private string _path_k__BackingField;
	[CompilerGenerated]
	private uint _bindId_k__BackingField;

	// Properties
	public string path { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public uint bindId { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	public enum BindType
	{
		Cpk = 0,
		Directory = 1,
		File = 2
	}

	// Constructors
	public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path);

	// Methods
	public override void Stop();
	public override void Update();
	protected override void Dispose(bool disposing);
}

