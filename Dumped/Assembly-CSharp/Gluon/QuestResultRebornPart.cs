/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRebornPart : MonoBehaviour
	{
		// Fields
		public QuestResultRebornHeartAnimation[] rebornHeartAnimations;
		public float heartAnimationInterval;
		public GameObject infinityImage;
		private const string prefabPath = "Prefabs/OutGame/QuestResult/QuestResultRebornPart";
	
		// Constructors
		public QuestResultRebornPart();
	
		// Methods
		public static QuestResultRebornPart Create(Transform parent, out Sequence rebornHeartAnimations);
		private void InitWithSequence(out Sequence sequenceHeartAnim);
	}
}
