/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExchangeSummonSelectItemCtrl : TableViewController<Gluon.ExchangeSummonSelectItemCellData>
	{
		// Fields
		[SerializeField]
		private AnimationListOneCol listAnimation;
		[SerializeField]
		private float delayFrame;
		public GiftType giftType;
		private int summonId;
		private const float cellHeight = 148f;
	
		// Constructors
		public ExchangeSummonSelectItemCtrl();
	
		// Methods
		protected override void Awake();
		public void Init(int summonId, List<ulong> idList, Action<ExchangeSummonSelectItemCellData> onClick);
		public void ReloadContents(List<ulong> idList, Action<ExchangeSummonSelectItemCellData> onClick);
		protected override TableViewCell<ExchangeSummonSelectItemCellData> CreateCellForIndex(int index);
		protected override float GetCellHeightAtIndex(int index);
		public void StartEnterAnimation();
		public void StartExitAnimation();
	}
}
