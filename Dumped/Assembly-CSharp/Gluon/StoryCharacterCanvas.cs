/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryCharacterCanvas : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Canvas uiCanvas;
		[SerializeField]
		public RectTransform[] characterRects;
		[SerializeField]
		public DifferenceImageController[] imageCtrls;
		[SerializeField]
		public CanvasGroup[] characterGroups;
		[SerializeField]
		public CanvasGroup characterParentGroup;
		[SerializeField]
		public RectTransform characterParent;
		[SerializeField]
		public Image characterFrontLayerImage;
		[SerializeField]
		public CanvasGroup characterFrontLayerGroup;
	
		// Constructors
		public StoryCharacterCanvas();
	}
}
