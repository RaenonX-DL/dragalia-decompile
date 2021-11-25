using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Cute.Cri.Audio
{
	[StructLayout(0, Size = 12)]
	public struct CuteAudioPriority
	{
		private bool isValidLevel;

		private int level;

		public int Level
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsPreferFirst
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
