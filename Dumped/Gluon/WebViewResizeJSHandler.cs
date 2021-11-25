using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class WebViewResizeJSHandler : MonoBehaviour
	{
		private const string SET_ZOOM_JS_FUNC = "setZoom()";

		private const float setZoomTime = 1f;

		private bool setZoom;

		private float timer;

		public Action SetMarginAction
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
