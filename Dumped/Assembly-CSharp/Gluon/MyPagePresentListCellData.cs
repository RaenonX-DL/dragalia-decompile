/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentListCellData
	{
		// Fields
		public string itemName;
		public MyPagePresentListPopup.ItemCategory itemCategory;
		public MyPagePresentListPopup.TypeTab type;
		public PresentDetailList presentData;
		public PresentHistoryList historyData;
		public UnityAction<MyPagePresentListCellData> detailCallback;
		public UnityAction<MyPagePresentListCellData, Canvas[]> iconLongPressedCallback;
	
		// Constructors
		public MyPagePresentListCellData();
	}
}
