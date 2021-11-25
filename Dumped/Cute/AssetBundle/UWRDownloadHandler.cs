using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Networking;

namespace Cute.AssetBundle
{
	public class UWRDownloadHandler : DownloadHandlerScript
	{
		private FileStream fileStream;

		private Action receiveDataCallback;

		public bool IsError
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ErrorMessage
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

		public UWRDownloadHandler(string path, byte[] buffer, [Optional] Action receiveDataCallback)
		{
		}

		protected override bool ReceiveData(byte[] data, int dataLength)
		{
			return default(bool);
		}

		public void Finish()
		{
		}
	}
}
