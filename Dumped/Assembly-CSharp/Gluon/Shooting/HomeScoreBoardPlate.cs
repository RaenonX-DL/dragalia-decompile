/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class HomeScoreBoardPlate : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image plateImage;
		[SerializeField]
		private Image bossImage;
		[SerializeField]
		private GameObject bossLevelNode;
		[SerializeField]
		private UnityEngine.UI.Text bossLevelText;
		[SerializeField]
		private UnityEngine.UI.Text scoreText;
		[SerializeField]
		private GameObject newScoreIcon;
		[SerializeField]
		private List<Sprite> plateImageList;
		[SerializeField]
		private List<Sprite> bossImageList;
		public Animator animator;
		private Vector2 blinkingToFrom;
		private float blinkingDuring;
		private Ease blinkingEasing;
		private Sequence blinkSeq;
	
		// Constructors
		public HomeScoreBoardPlate();
	
		// Methods
		public void Init(Transform node, int scoreRank, int score, int enemyRank, bool isNewScore, STGDataManager.Mode mode);
		private void SetPlateImage(int rank);
		public void SetAnimation(bool isIn);
		private void SetBossImage(int level, STGDataManager.Mode mode);
		private void SetNewScoreTween();
	}
}
