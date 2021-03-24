/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameGradationManager : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private Gradient _chainSkillButtonGradient;
		private Texture2D[] _textureList;
		public static readonly int enumGradationTypeCount;
	
		// Nested types
		public enum GradationType
		{
			ChainSkillButton = 0
		}
	
		// Constructors
		public InGameGradationManager();
		static InGameGradationManager();
	
		// Methods
		public void Setup(GradationType type);
		private void Setup(GradationType type, ref Gradient gradient);
		private void OnDestroy();
		public Texture2D GetTexture(GradationType type);
	}
}
