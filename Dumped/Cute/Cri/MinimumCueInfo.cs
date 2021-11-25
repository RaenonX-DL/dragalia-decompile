using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cute.Cri.Audio;

namespace Cute.Cri
{
	public class MinimumCueInfo : IDisposable
	{
		private GCHandle gch;

		private byte[] bytes;

		private IntPtr ptr => default(IntPtr);

		public string Name
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

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float MinDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float MaxDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float InteriorDistance
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float InteriorSourceRadius
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info);

		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info);

		public void Dispose()
		{
		}

		public bool AnalyzeCueInfo(CriAtomExAcb acb, RequestCueInfo requestCueInfo)
		{
			return default(bool);
		}
	}
}
