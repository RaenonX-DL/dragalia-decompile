/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NPF.ProtoBuf;
using ProtoBuf;
using ProtoBuf.Meta;

// Image 46: bridging_model_serializer.dll - Assembly: bridging_model_serializer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public sealed class BridgingModelSerializer : TypeModel
{
	// Fields
	private static readonly Type[] knownTypes;

	// Constructors
	public BridgingModelSerializer();
	static BridgingModelSerializer();

	// Methods
	private static void Write(NPFError.ErrorType param_0000773d, ProtoWriter param_0000773e);
	private static NPFError.ErrorType Read(NPFError.ErrorType param_0000773f, ProtoReader param_00007740);
	private static void Write(ProfanityWord param_00007741, ProtoWriter param_00007742);
	private static ProfanityWord Read(ProfanityWord param_00007743, ProtoReader param_00007744);
	private static void Write(ProfanityWord.ProfanityCheckStatus param_00007745, ProtoWriter param_00007746);
	private static ProfanityWord.ProfanityCheckStatus Read(ProfanityWord.ProfanityCheckStatus param_00007747, ProtoReader param_00007748);
	private static void Write(ProfanityWord.ProfanityDictionaryType param_00007749, ProtoWriter param_0000774a);
	private static ProfanityWord.ProfanityDictionaryType Read(ProfanityWord.ProfanityDictionaryType param_0000774b, ProtoReader param_0000774c);
	private static void Write(ProfanityWordList param_0000774d, ProtoWriter param_0000774e);
	private static ProfanityWordList Read(ProfanityWordList param_0000774f, ProtoReader param_00007750);
	private static void Write(SubscriptionTransaction param_00007751, ProtoWriter param_00007752);
	private static SubscriptionTransaction Read(SubscriptionTransaction param_00007753, ProtoReader param_00007754);
	private static void Write(SubscriptionTransaction.SubscriptionTransactionState param_00007755, ProtoWriter param_00007756);
	private static SubscriptionTransaction.SubscriptionTransactionState Read(SubscriptionTransaction.SubscriptionTransactionState param_00007757, ProtoReader param_00007758);
	private static void Write(SubscriptionTransactionList param_00007759, ProtoWriter param_0000775a);
	private static SubscriptionTransactionList Read(SubscriptionTransactionList param_0000775b, ProtoReader param_0000775c);
	protected new int GetKeyImpl(Type param_0000775d);
	protected internal new bool SerializeDateTimeKind();
	protected internal new void Serialize(int param_0000775e, object param_0000775f, ProtoWriter param_00007760);
	protected internal new object Deserialize(int param_00007761, object param_00007762, ProtoReader param_00007763);
	static object _1(object param_00007764, ProtoReader param_00007765);
	static object _3(object param_00007766, ProtoReader param_00007767);
	static object _4(object param_00007768, ProtoReader param_00007769);
	static object _7(object param_0000776a, ProtoReader param_0000776b);

	// Extension methods
	private static void Write(this NPFError param_00007739, ProtoWriter param_0000773a);
	private static NPFError Read(this NPFError param_0000773b, ProtoReader param_0000773c);
}

