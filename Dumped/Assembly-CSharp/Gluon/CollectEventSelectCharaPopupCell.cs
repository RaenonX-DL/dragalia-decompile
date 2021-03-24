/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CollectEventSelectCharaPopupCell : MonoBehaviour
	{
		// Fields
		public Image bgImage;
		public UnityEngine.UI.Text titleText;
		public GameObject lockGO;
		public UnityEngine.UI.Text unlockItemCount;
		public Image unlockItemIcon;
		private EventStoryElement data;
		private bool read;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__9_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnStoryCellClicked_b__9_0();
		}
	
		// Constructors
		public CollectEventSelectCharaPopupCell();
	
		// Methods
		public void SetContent(EventStoryElement data);
		public void OnClick();
		private void OnStoryCellClicked();
		private void DownloadCompleteCallback(int storyId);
		private bool IsEnabled();
		[CompilerGenerated]
		private void _OnStoryCellClicked_b__9_1();
	}
}
