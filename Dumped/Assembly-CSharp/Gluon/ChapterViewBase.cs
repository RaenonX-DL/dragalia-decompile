/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChapterViewBase : MonoBehaviour
	{
		// Fields
		public GameObject capterCellOrigin;
		public Image capterTitle;
		private List<ChapterCellData> chapterDataList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public UnityAction<int> pressButtonAction;
			public ChapterViewBase __4__this;
			public UnityAction<int> __9__0;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _SetupChapterView_b__0(int tag);
		}
	
		// Constructors
		public ChapterViewBase();
	
		// Methods
		public void SetupChapterView(StoryListCellData data, float listScrollPos, UnityAction<int> pressButtonAction);
		private void GetChapterData();
	}
}
