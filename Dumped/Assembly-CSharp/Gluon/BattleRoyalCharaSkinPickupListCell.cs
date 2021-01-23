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
	public class BattleRoyalCharaSkinPickupListCell : MonoBehaviour
	{
		// Fields
		public Image charaIcon;
		public Image skillIcon;
		public UnityEngine.UI.Text skillText;
		public GameObject summonButtonObject;
		public GameObject releaseButtonObject;
		public GameObject releasedTextObject;
		[CompilerGenerated]
		private int _skinId_k__BackingField;
		public Action goSummonCallBack;
		public Action<int> releaseSkinCallBack;
		private int specialSkillId;
	
		// Properties
		[HideInInspector]
		public int skinId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public BattleRoyalCharaSkinPickupListCell();
	
		// Methods
		public void InitCell(int charaSkinId);
		public void UpdateCellButton();
		public void OnSummonButtonPressed();
		public void OnReleaseButtonPressed();
		public void OnSkillCellPressed();
	}
}
