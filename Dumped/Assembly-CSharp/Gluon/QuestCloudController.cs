/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCloudController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private QuestCloud[] questCloudList;
		[SerializeField]
		private bool isSetCustomRenderQueue;
		[SerializeField]
		private int customRenderQueueValue;
		private bool _isPlay;
		private float targetMaxPosY;
		private float targetMinPosY;
		private float targetLeftPosX;
		private float targetRightPosX;
		private bool isTargetInfo;
	
		// Properties
		public QuestCloud[] QuestCloudList { get; }
		public bool isPlay { get; }
	
		// Constructors
		public QuestCloudController();
	
		// Methods
		private void Start();
		public void PlayCloud(Vector2 worldMapSize);
		public void IsCloud(bool enable);
		public void IsShadow(bool enable);
		public void SetTargetRange(float max, float min, float left = 0f, float right = 0f);
		private void Update();
		private void chcekCloudCover();
	}
}
