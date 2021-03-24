/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CharaController : MonoBehaviour, ICuttTimelineCharactorLocator
{
	// Fields
	public Transform _headNode;
	public Transform _chestNode;
	public Transform _footNode;
	public Transform _positionNode;
	public Animation _animation;
	[CompilerGenerated]
	private bool _cuttCharaVisible_k__BackingField;
	private CuttCharaPosition _cuttCharaStandingPosition;
	private Vector3 _cuttCharaInitialPosition;
	[CompilerGenerated]
	private int _cuttCharaHeightLevel_k__BackingField;
	[CompilerGenerated]
	private float _cuttCharaHeightRatio_k__BackingField;

	// Properties
	public bool cuttCharaVisible { [CompilerGenerated] get; [CompilerGenerated] set; }
	public CuttCharaPosition cuttCharaStandingPosition { get; set; }
	public Vector3 cuttCharaInitialPosition { get; set; }
	public Vector3 cuttCharaHeadPosition { get; }
	public Vector3 cuttCharaChestPosition { get; }
	public Vector3 cuttCharaFootPosition { get; }
	public Animation cuttAnimationComponent { get; }
	public Transform cuttRootTransform { get; }
	public int cuttCharaHeightLevel { [CompilerGenerated] get; [CompilerGenerated] set; }
	public float cuttCharaHeightValue { get; }
	public float cuttCharaHeightRatio { [CompilerGenerated] get; [CompilerGenerated] set; }

	// Constructors
	public CharaController();
}

