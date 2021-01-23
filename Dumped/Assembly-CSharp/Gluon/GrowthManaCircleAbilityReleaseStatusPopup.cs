/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseStatusPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text subTitle1;
		public UnityEngine.UI.Text label1;
		public UnityEngine.UI.Text beforeNum;
		public UnityEngine.UI.Text afterNum;
		public Transform statusBase2;
		public UnityEngine.UI.Text statusLabel2;
		public UnityEngine.UI.Text beforeNum2;
		public UnityEngine.UI.Text afterNum2;
		public UnityEngine.UI.Text subTitle2;
		public UnityEngine.UI.Text label2;
		public UnityEngine.UI.Text requiredMpNum;
		public UnityEngine.UI.Text currentMPNum;
		public UnityEngine.UI.Text afterMPNum;
		public UnityEngine.UI.Text warningText;
		public UnityEngine.UI.Text newStoryText;
		public UnityEngine.UI.Text storyDescText;
		public Image storyIcon;
		public GameObject storyLockLayer;
		public bool isReleaseStory;
		public GameObject manaOrdewRequiredObj;
		public GameObject materialObj;
		public GrowthManaCircleReleaseMaterialIcon icon;
	
		// Constructors
		public GrowthManaCircleAbilityReleaseStatusPopup();
	
		// Methods
		public static GrowthManaCircleAbilityReleaseStatusPopup Create(bool isReleaseStory);
		public void SetParameters(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleModel model, int currentMP, bool isCircleReleased = true, bool isReleasePrevPiece = true);
	}
}
