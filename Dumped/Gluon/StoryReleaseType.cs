using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum StoryReleaseType
	{
		NONE,
		CHARA_GET,
		CHARA_CHARA_GROW,
		DRAGON_RELIABILITY_LEVEL
	}
}
