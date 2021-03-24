/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailInfoBaseCell : MonoBehaviour
	{
		// Fields
		public UnityAction<int, int, int> iconCallBack;
		[Header]
		[SerializeField]
		public Image icon;
		public GameObject levelGO;
		public UnityEngine.UI.Text levelText;
		public UnityEngine.UI.Text nameText;
		[Header]
		[SerializeField]
		public GameObject lockedPanel;
		public GameObject normalPanel;
		public GameObject nonePanel;
		[Header]
		[SerializeField]
		public Image charaBG;
		public Image weaponBG;
		public Image dragonBG;
		public Image amuletBG;
		public Image unionBG;
		protected int dataId;
		protected int level;
		protected int maxLevel;
		protected bool isLockCell;
	
		// Constructors
		public UnitDetailInfoBaseCell();
	
		// Methods
		public void Start();
		public virtual void IconPressed();
		public void SetBGImage(AbilityConst.UnitType giftType);
	}
}
