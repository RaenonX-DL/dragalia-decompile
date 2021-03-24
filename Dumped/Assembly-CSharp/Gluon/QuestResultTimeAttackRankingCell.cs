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
	public class QuestResultTimeAttackRankingCell : MonoBehaviour
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
		private UnityEngine.UI.Text timeText;
		[SerializeField]
		private Image bgFront;
		[SerializeField]
		private float fadeInTime;
		[SerializeField]
		private float fadeOutTime;
		private CommonIconListSortDeco[] charaListSortDeco;
		private const int fontSizeUseIntergerClearTime = 40;
		private const int fontSizeUseFloatClearTime = 31;
	
		// Constructors
		public QuestResultTimeAttackRankingCell();
	
		// Methods
		public void InitSetting(TimeAttackRanking.RankingInfo data);
		[ContextMenu]
		public void RankInAnimation();
	}
}
