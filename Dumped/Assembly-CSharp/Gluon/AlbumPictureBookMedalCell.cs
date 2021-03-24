/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureBookMedalCell : TableViewCell<Gluon.AlbumPictureBookMedalCellData>
	{
		// Fields
		[SerializeField]
		private RawImage medal;
		[SerializeField]
		private UnityEngine.UI.Text text;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _OnIconPressed_b__0();
		}
	
		// Constructors
		public AlbumPictureBookMedalCell();
	
		// Methods
		public override void UpdateContent(AlbumPictureBookMedalCellData itemData);
		public void OnIconPressed();
	}
}
