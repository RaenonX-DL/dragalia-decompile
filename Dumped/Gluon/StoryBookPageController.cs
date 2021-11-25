using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class StoryBookPageController : FastUpdateMonoBehaviour
	{
		private enum State
		{
			None,
			Idle,
			Proceeding
		}

		public const int numOfPages = 7;

		public GameObject[] pageObjects;

		public List<GameObject> textPageObjects;

		public List<StoryTextManager.LogData> textPageLogs;

		public const int maxBreakType = 3;

		public GameObject[] textPageObjectsOriginal;

		public const float renderWait = 0.1f;

		private const string texturePath = "Images/Story/BookPage/";

		public const string pageMainTexture = "sty_3d_0001_{0:D2}";

		public const string pageBackTexture = "sty_3d_0001_00";

		public bool isTextPage;

		public int textSize;

		public Color textColor;

		private int currentPageIndex;

		private Animation pageAnimation;

		private State pageState;

		private Camera mainCamera;

		private Camera textCamera;

		public StoryBookTextCanvas canvasScript;

		private RenderTexture renderTexture;

		private StoryBookPageSettings settings;

		public static StoryBookPageController instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static StoryBookPageController Create()
		{
			return null;
		}

		public static bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		public void StartProloguePage()
		{
		}

		public void StartTextPage()
		{
		}

		public void Finish()
		{
		}

		public void StartPageControl()
		{
		}

		private GameObject CreatePageObject(int index)
		{
			return null;
		}

		public void AddTextPageObject(string fileName = "")
		{
		}

		public void ChangeBookTexture()
		{
		}

		public void AdvancePage()
		{
		}

		private void AdjustPagesPositionOnAdvance()
		{
		}

		private void AdjustTextPagesPositionOnAdvance()
		{
		}

		private void StartPageDown(GameObject pageObject)
		{
		}

		public override void FastUpdate()
		{
		}

		public bool CanProcessPage()
		{
			return default(bool);
		}
	}
}
