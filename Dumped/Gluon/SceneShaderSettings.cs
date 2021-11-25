using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class SceneShaderSettings : MonoBehaviour
	{
		public delegate void delegateChangedBackgroundShaderParameter();

		public delegate void delegateChangedCharaShaderParameter();

		[HideInInspector]
		public SceneRichShaderData sceneRichShaderData;

		[HideInInspector]
		public BackgroundShaderParameter backgroundShaderParameter;

		[HideInInspector]
		public CharaShaderParameter charaShaderParameter;

		public event delegateChangedBackgroundShaderParameter eventChangedBackgroundShaderParameter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event delegateChangedCharaShaderParameter eventChangedCharaShaderParameter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual void OnChangedBackgroundShaderParameter()
		{
		}

		public virtual void OnChangedCharaShaderParameter()
		{
		}

		private void Awake()
		{
		}
	}
}
