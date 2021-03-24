/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsWebInstallRequest : CriFsInstallRequest
{
	// Fields
	private CriFsWebInstaller installer;
	private uint crc32;
	private bool crc32_set;

	// Constructors
	public CriFsWebInstallRequest(string srcPath, string dstPath, DoneDelegate doneDelegate);

	// Methods
	public override void Stop();
	public bool GetCRC32(out uint ret_val);
	public override void Update();
	protected override void Dispose(bool disposing);
}

