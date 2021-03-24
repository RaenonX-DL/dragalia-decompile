/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonItem : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text upperText;
		[SerializeField]
		private UnityEngine.UI.Text lowerText;
		[SerializeField]
		private UnityEngine.UI.Text obtainedText;
		[SerializeField]
		private Image itemBgImage;
		private GiftType giftType;
		private int id;
		private int twoStepId;
		private int quantity;
		private EventQuestPageBase currentPage;
		private PopupBase parentPopup;
	
		// Constructors
		public BoxSummonItem();
	
		// Methods
		public void SetContent(AtgenBoxSummonDetail itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size, int index = 0);
		public void SetContent(AtgenDrawDetails itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size);
		public void SetContent(AtgenBuildEventRewardEntityList itemData, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size);
		private void Init(string remainValueStr, string totalValueStr, IconLoader.Size size, bool shouldShowCountPlate, int index = 0);
		public void SetContent(BoxSummonResultPopup.BoxSummonResultPickUpData data, EventQuestPageBase page, PopupBase parentPopup, IconLoader.Size size);
		private void InitResult(BoxSummonResultPopup.BoxSummonResultPickUpData data, IconLoader.Size size, bool shouldShowCountPlate);
		public void OnIconTouched();
		[CompilerGenerated]
		private void _OnIconTouched_b__17_0();
	}
}
