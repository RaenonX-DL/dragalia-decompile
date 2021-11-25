using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Cute.Cri.Audio
{
	[StructLayout(0, Size = 24)]
	public struct RequestCueInfo
	{
		public string CueSheetName
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

		public string CueName
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

		public int CueId
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

		public RequestCueInfo(string cueSheetName, string cueName)
		{
		}

		public RequestCueInfo(string cueSheetName, int cueId)
		{
		}
	}
}
