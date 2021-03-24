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
	public class QuestDifficultyIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image frameImage;
		[SerializeField]
		private Sprite[] difficultySprites;
		[SerializeField]
		private Material[] difficultyMaterials;
		[SerializeField]
		private float[] difficultySpriteScales;
		private Vector3 tempScale;
	
		// Constructors
		public QuestDifficultyIcon();
	
		// Methods
		public void SetupDifficultyIcon(QuestSelectScene.Difficulty difficulty);
	}
}
