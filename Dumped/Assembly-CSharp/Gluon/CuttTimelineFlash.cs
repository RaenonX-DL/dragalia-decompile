/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CuttTimelineFlash
	{
		// Fields
		private CuttTimelineKeyFlashDataList _keys;
		private CuttTimelineControl _timelineControl;
		private CuttFlashInitializeData _initData;
	
		// Constructors
		public CuttTimelineFlash();
	
		// Methods
		public void Initialize(CuttTimelineKeyFlashDataList keys, CuttTimelineControl timelineControl, CuttFlashInitializeData initData);
		public void AlterUpdate(float targetFps, int currentFrame, int oldFrame);
	}
}
