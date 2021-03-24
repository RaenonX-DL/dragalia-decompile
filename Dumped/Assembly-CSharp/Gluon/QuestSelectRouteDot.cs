/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectRouteDot : QuestSelectRoutePoint
	{
		// Fields
		[SerializeField]
		private Image baseImage;
		[SerializeField]
		private Image activeImage;
		[SerializeField]
		private Vector3 effectOffsetPos;
		[SerializeField]
		private Vector3 effectScale;
		private EffectObject activationEffect;
		public DotStatus _status;
		private Quaternion quaternion;
	
		// Properties
		public DotStatus dotStatus { get; set; }
	
		// Nested types
		private enum TriggerId
		{
			Blue = 8,
			Orange = 9,
			BlueLoop = 10
		}
	
		public enum DotStatus
		{
			DropWhiteIcon = 0,
			DropBlueIcon = 1,
			AppearBlueIcon = 2
		}
	
		// Constructors
		public QuestSelectRouteDot();
	
		// Methods
		private void Start();
		public override void StartActivation();
		private void IconDrop(Image image);
		public override void ActivateImmediately();
		public void PlayActivationEffect();
		public void ShowActiveImage();
		public void SetActiveImageRotation(float angle);
	}
}
