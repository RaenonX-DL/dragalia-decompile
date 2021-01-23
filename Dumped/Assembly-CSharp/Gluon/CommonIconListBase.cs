/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIconListBase : MonoBehaviour
	{
		// Fields
		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonCallBack;
		public UnityAction<CommonIconListCellData, TableViewCell<CommonIconListCellData>> listButtonLongPressCallBack;
		public UnityAction outButtonCallBack;
		public UnityAction outButtonLongPressCallBack;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text countText;
		public bool isShowListCount;
		[HideInInspector]
		public CommonSortButton sortButton;
		[Header]
		[SerializeField]
		public Transform sortButtonPlaceHolder;
		public UnityAction onSortButtonClicked;
		public bool isShowSortButton;
		public bool isDisableAutoLoadSortButton;
		[SerializeField]
		private GameObject countTextGameObject;
	
		// Constructors
		public CommonIconListBase();
	
		// Methods
		public virtual void Awake();
		public void SetCountTextActive(bool active);
		public virtual void SetupCountText(int nowCount, int maxCount);
		public virtual void SetupCountText(int nowCount);
		public virtual void SetupCharaCountText(int nowCount);
		public void SetupSkillCountText(int nowCount);
		public void SetupAmuletCountText(int nowCount);
		public void OnSortButtonClicked();
		public void SetSortButtonActive(bool isActive);
		public void LoadSortButton();
		public bool IsLoadedSortButton();
		[CompilerGenerated]
		private void _LoadSortButton_b__21_0(UnityEngine.Object prefab);
	}
}
