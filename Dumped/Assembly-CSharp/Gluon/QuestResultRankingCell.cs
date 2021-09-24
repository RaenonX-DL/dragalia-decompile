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
	public class QuestResultRankingCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon[] commonIcons;
		[SerializeField]
		private GameObject[] emptyIcons;
		[SerializeField]
		private Transform[] charaListSortDecoTrans;
		[SerializeField]
		private GameObject newIcon;
		[SerializeField]
		private UnityEngine.UI.Text rankingFactorText;
		[SerializeField]
		private Image bgFront;
		[SerializeField]
		private float fadeInTime;
		[SerializeField]
		private float fadeOutTime;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text currentDamageText;
		private CommonIconListSortDeco[] charaListSortDeco;
		private const int fontSizeUseIntergerClearTime = 40;
		private const int fontSizeUseFloatClearTime = 31;
	
		// Constructors
		public QuestResultRankingCell();
	
		// Methods
		public void InitSetting(TimeAttackRanking.RankingInfo data);
		public void InitSetting(TotalDamageEventRankingData.RankingInfo rankingData);
		[ContextMenu]
		public void RankInAnimation();
	}
}
