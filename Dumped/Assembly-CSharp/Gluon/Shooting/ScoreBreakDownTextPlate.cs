﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ScoreBreakDownTextPlate : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text rankText;
		[SerializeField]
		private UnityEngine.UI.Text scoreText;
		[SerializeField]
		private UnityEngine.UI.Text numText;
		[SerializeField]
		private UnityEngine.UI.Text totalText;
	
		// Constructors
		public ScoreBreakDownTextPlate();
	
		// Methods
		public void Init(int rank, STGDataManager.CurrentGameData.EnemyRankBreakdown enemyRankBreakdown);
	}
}
