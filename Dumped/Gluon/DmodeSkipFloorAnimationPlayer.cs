using System;
using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class DmodeSkipFloorAnimationPlayer : MonoBehaviour
	{
		[SerializeField]
		[Header("CountUpFloorNum")]
		private Sprite[] numberImageList;

		[SerializeField]
		private Material dmodeAtrasMaterial;

		private FlMotion skipFloorMotionObj;

		private FlPlane[] floorNumImageObjList;

		private FlMotion floorNumMotionObj;

		private Action onAnimationFinished;

		private const int maxDigitsCount = 3;

		private static readonly int startFloorNum;

		private static readonly int countUpAnimationFrameNum;

		private bool isIniaizelized;

		private static Dictionary<string, int> floorNumReplaceObjDigitTable;

		private static string[] floorNumAnimationDigitsLabelList;

		private static readonly string floorNumMotObjName;

		private static readonly string skipFloorAnimationStartLabel;

		private static readonly string skipFloorAnimationCountUpLabel;

		private static readonly string skipFloorAnimationSkipTextInLabel;

		private static readonly string skipFloorAnimationEndLabel;

		private static readonly string skipFloorAnimationPath;

		private static readonly string skipSeName;

		private void Start()
		{
		}

		private void SetupSkipFloorAnimation(FlRoot skipFloorAnimationFlRoot)
		{
		}

		private IEnumerator CountUpFloorNum(int skipFloorNum)
		{
			return null;
		}

		private void SetUpFloorNumImagePanel(int value)
		{
		}

		private void SetUpFloorNumImagePanel(int value, int digitsCount)
		{
		}

		public void AddOnAnimationFinished(Action callback)
		{
		}

		public void SetupSkipFloorNum(int skipFloorNum)
		{
		}

		public IEnumerator StartAnimation()
		{
			return null;
		}
	}
}
