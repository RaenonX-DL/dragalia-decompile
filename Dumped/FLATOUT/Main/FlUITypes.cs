using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlUITypes
	{
		None,
		Button,
		CheckButton,
		ImageNumber,
		ProgressBar,
		ScrollBar,
		SlideBar,
		CheckButtonList,
		TextScroll,
		ObjectScroll,
		ObjectScrollList,
		UpDownArrow
	}
}
