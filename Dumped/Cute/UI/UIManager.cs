using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Cute.UI
{
	[ProjectPrefsAttr("UILayer_0", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_1", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_2", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_3", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_4", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_5", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_6", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_7", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_8", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	[ProjectPrefsAttr("UILayer_9", "UIç\u0094\u00a8ã\u0083¬ã\u0082¤ã\u0083¤ã\u0083¼å\u0090\u008dè\u00a8­å®\u009a æ\u0095°å­\u0097ã\u0081\u008cå°\u0091ã\u0081ªã\u0081\u0084ã\u0081»ã\u0081\u0086ã\u0081\u008cå¥¥ã\u0081«ã\u0081ªã\u0082\u008b", "[UI]")]
	public class UIManager : MonoBehaviour
	{
		public const string PrefsPrefix = "UILayer_";

		public const string ToolTip = "UI用レイヤー名設\ufffd";

		public const string Group = "[UI]";

		public const int MaxLayer = 10;

		private Dictionary<string, Transform> layers;

		private List<Window> windowBuffer;

		public static UIManager Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public void AddControl(RectTransform control, string layer)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
