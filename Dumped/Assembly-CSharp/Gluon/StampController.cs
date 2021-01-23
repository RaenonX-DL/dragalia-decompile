/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampController : PageScrollController<Gluon.StampPageData>
	{
		// Fields
		[SerializeField]
		private StampCarsouseIcons carsouselIcons;
		public UnityAction<int> pageButtonCallBack;
		private const int maxStampData = 24;
		private const string changePageSe = "SE_OUT_COMMON_0005";
	
		// Constructors
		public StampController();
	
		// Methods
		protected override void Start();
		private void OnIconPressed(int selectStampID);
		protected override void ChangePage(int index);
		public void ChangePageButton(int direction);
		private void UpdateCarsousel();
	}
}
