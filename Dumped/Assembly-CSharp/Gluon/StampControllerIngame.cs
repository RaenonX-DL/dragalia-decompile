/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampControllerIngame : PageScrollController<Gluon.StampPageData>
	{
		// Fields
		[Header]
		[SerializeField]
		private StampCarsouseIcons carsouselIcons;
		[Header]
		[SerializeField]
		[Tooltip]
		private float carsouseIconMergin;
		public UnityAction<int> pageButtonCallBack;
		[CompilerGenerated]
		private bool _Initialized_k__BackingField;
		protected int pageDataNum;
		private const string changePageSe = "SE_OUT_COMMON_0005";
	
		// Properties
		public bool Initialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public StampControllerIngame();
	
		// Methods
		protected override void Start();
		private void OnIconPressed(int selectStampID);
		protected override void ChangePage(int index);
		public void ChangePageButton(int direction);
		private void UpdateCarsousel();
		public void ApplyCarsouselIcon();
	}
}
