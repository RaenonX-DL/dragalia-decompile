/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class UWRDownloadHandler : DownloadHandlerScript
	{
		// Fields
		[CompilerGenerated]
		private bool _IsError_k__BackingField;
		[CompilerGenerated]
		private string _ErrorMessage_k__BackingField;
		private FileStream fileStream;
		private Action receiveDataCallback;
	
		// Properties
		public bool IsError { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string ErrorMessage { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public UWRDownloadHandler(string path, byte[] buffer, Action receiveDataCallback = null);
	
		// Methods
		protected override bool ReceiveData(byte[] data, int dataLength);
		public void Finish();
	}
}
