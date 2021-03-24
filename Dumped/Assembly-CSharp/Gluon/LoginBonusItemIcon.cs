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
	public class LoginBonusItemIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private GameObject getMark;
		[SerializeField]
		private UnityEngine.UI.Text DayText;
		[SerializeField]
		private Animator getMarkAnimator;
		[SerializeField]
		private GameObject haloObject;
		[SerializeField]
		private Animator haloAnimator;
		private bool isSkipTicket;
	
		// Constructors
		public LoginBonusItemIcon();
	
		// Methods
		public void SetContent(LoginBonusRewardElement itemData);
		public bool IsSkipTicket();
		public void SetContent(GiftType giftType, int id, int count, int day);
		public void SetGetMark(bool isGotten, bool withAnimation);
		public void SetHaloLight(bool isShow);
		public void SetGetColor(bool isGotten);
	}
}
