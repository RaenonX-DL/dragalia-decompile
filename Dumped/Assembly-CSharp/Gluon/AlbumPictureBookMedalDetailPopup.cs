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
	public class AlbumPictureBookMedalDetailPopup : CommonIconPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text IconName;
		private AlbumPictureBookMedalCellData itemData;
	
		// Constructors
		public AlbumPictureBookMedalDetailPopup();
	
		// Methods
		public static AlbumPictureBookMedalDetailPopup Create();
		public void InitContent(AlbumPictureBookMedalCellData itemData);
		public override void OnCloseButtonPressed();
		public override void OnCancelButtonPressed();
		public override void OnOkButtonPressed();
	}
}
