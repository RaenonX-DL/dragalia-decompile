/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineRichShader
	{
		// Fields
		private CuttTimelineKeyRichShaderDataList _keys;
	
		// Constructors
		public CuttTimelineRichShader();
	
		// Methods
		public void Initialize(CuttTimelineKeyRichShaderDataList keys, CuttTimelineControl timelineControl);
		private void SetRichSceneParam(CuttTimelineKeyRichShaderData nowData);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
