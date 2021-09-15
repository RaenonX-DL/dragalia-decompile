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
	public class CampaignImageSetting : MonoBehaviour
	{
		// Fields
		public Image singleImageViewImage;
		public GameObject campaignComment;
		public UnityEngine.UI.Text commentText;
		public SummonButton campaignButton;
		public Image campaignButtonNormalImage;
		public Image campaignButtonSelectedImage;
		public Image topBannerImage;
		public UnityEngine.UI.Text remainCountText;
		public GameObject remainCountBalloon;
		[SerializeField]
		private Image topActivePeriodImage;
		[SerializeField]
		private UnityEngine.UI.Text topActivePeriodText;
		[Header]
		[SerializeField]
		public Button switchSummonButton;
		public Sprite[] switchSummonButtonImages;
		public Action onSwitchSummon;
	
		// Constructors
		public CampaignImageSetting();
	
		// Methods
		public void Setup(SummonTopItemData topData);
		private void SetImage(string assetsPath, Image image, string pathTemplate);
		private string GenerateScheduleText(int summonId);
		public void OnSwitchSummonPressed();
	}
}
