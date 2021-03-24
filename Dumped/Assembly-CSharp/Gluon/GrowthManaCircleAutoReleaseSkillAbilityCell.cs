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
		private GrowthManaCircleModel model;
		private GrowthManaCircleManaPieceData pieceData;
	
		// Constructors
		public GrowthManaCircleAutoReleaseSkillAbilityCell();
	
		// Methods
		public void InitCell(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData);
		public void OnIconPressed();
		public void ShowAbilityDetail();
		public void ShowSkillDetail();
	}
}
