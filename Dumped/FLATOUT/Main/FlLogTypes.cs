using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlLogTypes
	{
		Initialize,
		Loaded,
		Finalize,
		Cannot__s__Find__s__Motion,
		___________________________DOWN,
		DownInStart,
		DownInEnd,
		DownOutStartOn,
		DownOutStartOff,
		DownOutStart,
		DownOutEndOn,
		DownOutEndOff,
		DownOutEnd,
		_________________________SELECT,
		SelectInStart,
		SelectInEnd,
		SelectOutStart,
		SelectOutEnd,
		___________________________OVER,
		OverInStart,
		OverInEnd,
		OverOutStart,
		OverOutEnd,
		___________________________CHECK,
		CheckStart,
		Checked,
		UnCheckStart,
		UnChecked,
		___________________________SCROLL,
		ScrollStart,
		ScrollOutStart,
		ScrollSprintStart,
		ScrollEnd,
		___________________________VALUE,
		ValueChangeStart,
		ValueChangeEnd,
		ValueChange,
		ValueChangeUp,
		ValueChangeDown
	}
}
