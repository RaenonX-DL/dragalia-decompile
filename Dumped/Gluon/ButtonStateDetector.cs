using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ButtonStateDetector : MonoBehaviour
	{
		public bool needSetColorWhenDisiable;

		public bool isAlphaA8;

		public bool isSetEnableColorWithChildren;

		public bool isPreIn;

		private Button button;

		private bool isDisabled;

		private bool isInitialSet;

		public List<GameObject> ignoreSetColorChildren;

		public GameObject[] disableStateObject;

		public bool isEnableStateImageHide;

		private Image enableStateImage;

		private void Awake()
		{
		}

		public void OnNormalStateChanged()
		{
		}

		public void OnDisableStateChanged()
		{
		}

		public void SetState(bool toDisable, bool force)
		{
		}
	}
}
