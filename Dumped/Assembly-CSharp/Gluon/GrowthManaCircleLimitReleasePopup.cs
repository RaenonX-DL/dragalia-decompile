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
	public class GrowthManaCircleLimitReleasePopup : CommonPopup, ICustomMessage
	{
		// Fields
		public UnityEngine.UI.Text insufficientText;
		public CommonIcon[] icons;
		public Image[] requiredLabels;
		public UnityEngine.UI.Text[] requiredNumText;
		public Image[] havingLabels;
		public UnityEngine.UI.Text[] havingNumText;
		public UnityEngine.UI.Text[] havingText;
		public Image[] tradeIcons;
		private readonly Color insufficientTextColor;
		private readonly Color insufficientRequiredColor;
		private readonly Color insufficientHavingColor;
		private readonly Color sufficientRequiredColor;
		private readonly Color sufficientHavingColor;
		private int circleIndex;
		private GrowthManaCircleModel model;
		private bool isReleased;
	
		// Constructors
		public GrowthManaCircleLimitReleasePopup();
	
		// Methods
		public static GrowthManaCircleLimitReleasePopup Create();
		private void OnEnable();
		private void OnDisable();
		public void SetParameters(int circleIndex, GrowthManaCircleModel model, bool isReleased = false);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
