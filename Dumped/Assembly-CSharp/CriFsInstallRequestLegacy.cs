/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsInstallRequestLegacy : CriFsInstallRequest
{
	// Fields
	private CriFsInstaller installer;

	// Constructors
	public CriFsInstallRequestLegacy(CriFsBinder srcBinder, string srcPath, string dstPath, DoneDelegate doneDelegate, int installBufferSize);

	// Methods
	public override void Stop();
	public override void Update();
	protected override void Dispose(bool disposing);
}

