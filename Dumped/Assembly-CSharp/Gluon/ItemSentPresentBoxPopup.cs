/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemSentPresentBoxPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
		[SerializeField]
		private ItemSentPresentBoxCtrl cellController;
		private static string puPrefabPath;
	
		// Constructors
		public ItemSentPresentBoxPopup();
		static ItemSentPresentBoxPopup();
	
		// Methods
		public static ItemSentPresentBoxPopup Create();
		public void SetText(string title, string description);
		public void SetContent(List<ItemSentPresentBoxCellData> itemDataList);
	}
}
