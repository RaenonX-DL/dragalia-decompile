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
	public class GrowthManaCircleAutoReleaseSkillAbilityCell : MonoBehaviour
	{
		// Fields
		public Image icon;
		private int charaId;
		private GrowthManaCircleManaPieceData pieceData;
		private int dataIndex;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _ShowBurstAttack_b__0();
		}
	
		// Constructors
		public GrowthManaCircleAutoReleaseSkillAbilityCell();
	
		// Methods
		public void InitCell(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, int dataIndex = 0);
		public void InitCell(int charaId, GrowthManaCircleManaPieceData pieceData, int dataIndex = 0);
		public void OnIconPressed();
		public void ShowAbilityDetail();
		public void ShowSkillDetail();
		public void ShowItemDetail();
		public void ShowBurstAttack();
	}
}
