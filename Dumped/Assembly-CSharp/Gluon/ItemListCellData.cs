/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemListCellData
	{
		// Fields
		public int itemId;
		public int ItemNum;
		public GiftType giftType;
		public string captionString;
		public string messageString;
		public UnityAction<ItemListCellData> pressedCallback;
		public int useLimit;
		public CellType cellType;
	
		// Nested types
		public enum CellType
		{
			Icon = 0,
			Caption = 1,
			Funds = 2,
			NoneIconLine = 3,
			NoneCaptionLine = 4,
			NoneFundsLine = 5,
			TextOnly = 6,
			NoneTextOnlyLine = 7
		}
	
		// Constructors
		public ItemListCellData();
	}
}
