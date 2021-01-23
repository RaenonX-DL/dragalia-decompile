/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultItemDetailPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text descriptionText;
		[Header]
		[SerializeField]
		public GameObject overLimitTextGO;
		public GameObject overLimitTextForPresentGO;
		public UnityEngine.UI.Text getCountText;
		public UnityEngine.UI.Text beforeText;
		public UnityEngine.UI.Text afterText;
		private GiftType giftType;
		private int id;
		private int limitBreak;
		private Rarity rarity;
	
		// Constructors
		public QuestResultItemDetailPopup();
	
		// Methods
		public static QuestResultItemDetailPopup Create(GiftType giftType, int id, int limitBreak = 0, Rarity rarity = Rarity.NONE);
		protected override void Start();
		internal static void Create(object p);
	}
}
