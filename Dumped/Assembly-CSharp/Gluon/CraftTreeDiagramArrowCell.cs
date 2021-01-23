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
	public class CraftTreeDiagramArrowCell : MonoBehaviour
	{
		// Fields
		public Image[] horizontalArrows;
		public Image[] virticalLines;
		public Image[] horizontalLines;
		public GameObject horizontalArrowBase;
		public GameObject virticalArrowBase;
		public GameObject virticalLine;
		public Sprite blueArrowSprite;
		public Sprite grayArrowSprite;
		public Sprite redArrowSprite;
		public Sprite blueLineSprite;
		public Sprite grayLineSprite;
		public Sprite redLineSprite;
		public Transform horizontalArrowsSpIconTransform;
		public Transform virticalArrowSpIconTransform;
		[HideInInspector]
		public CraftTreeArrowType arrowType;
		[HideInInspector]
		public bool blue;
		[CompilerGenerated]
		private bool _isSpUpgrade_k__BackingField;
	
		// Properties
		[HideInInspector]
		public bool isSpUpgrade { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public CraftTreeDiagramArrowCell();
	
		// Methods
		public void SetArrow(CraftTreeArrowType type, bool isBlue = true);
	}
}
