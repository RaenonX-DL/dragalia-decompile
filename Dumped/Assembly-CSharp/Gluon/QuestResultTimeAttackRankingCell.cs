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
	public class QuestResultTimeAttackRankingCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon[] commonIcons;
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
	
		// Constructors
		public QuestResultTimeAttackRankingCell();
	
		// Methods
		public void InitSetting(TimeAttackRanking.RankingInfo data);
		[ContextMenu]
		public void RankInAnimation();
	}
}
