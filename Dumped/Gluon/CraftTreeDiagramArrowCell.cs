using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftTreeDiagramArrowCell : MonoBehaviour
	{
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

		[HideInInspector]
		public bool isSpUpgrade
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetArrow(CraftTreeArrowType type, bool isBlue = true)
		{
		}
	}
}
