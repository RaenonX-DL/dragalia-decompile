/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRebornHeartAnimation : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Transform node;
		public GameObject offIcon;
		private FlRoot root;
		private const string prefabPath = "Prefabs/OutGame/QuestResult/pf_QuestResultRebornLifeIcon";
	
		// Constructors
		public QuestResultRebornHeartAnimation();
	
		// Methods
		private void Awake();
		public void Hide();
		public void HeartGray();
		public Sequence HeartIn(float delay);
		[CompilerGenerated]
		private void _HeartIn_b__7_0();
	}
}
