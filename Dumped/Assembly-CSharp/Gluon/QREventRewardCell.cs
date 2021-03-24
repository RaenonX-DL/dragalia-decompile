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
	public class QREventRewardCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
	
		// Constructors
		public QREventRewardCell();
	
		// Methods
		public void SetContent(MazeEventRewardElement reward);
		public void SetContent(BuildEventRewardElement reward);
		public void SetContent(GiftType rewardEntityType, int rewardEntityId, int rewardEntityQuantity);
	}
}
