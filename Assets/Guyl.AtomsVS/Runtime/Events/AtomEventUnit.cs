namespace Guyl.BoltAtoms.Events
{
	using Bolt;
	using Ludiq;
	using UnityAtoms;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	using System;
	using AtomsVS.Runtime.Utility;

	public abstract class AtomEventUnit<T, V> : MachineEventUnit<EmptyEventArgs> where T : AtomEvent<V>
	{
		#region FIELDS
		#region Public
		[DoNotSerializeAttribute] public ValueInput _event;
		[DoNotSerializeAttribute] public ValueOutput _value;

		[DoNotSerialize, UnitHeaderInspectable, UnitButton("TriggerButton")]
		public UnitButton _triggerButton;
		#endregion Public

		#region Private
		private EventUnit<T> _eventUnitImplementation;
		private Action<V> _eventRaisedHandler;
		private V _currentValue;
		#endregion Private
		#endregion FIELDS

		#region Properties
		protected override string hookName => "UnityAtomEvent";
		#endregion Properties

		#region METHODS
		#region Protected
		protected override void Definition()
		{
			_event = ValueInput<T>("", null);
			_value = ValueOutput<V>("", flow => _currentValue);
			base.Definition();
		}
		#endregion Protected

		#region Public
		public void TriggerButton(GraphReference reference)
		{
			if (Application.isEditor && Application.isPlaying)
			{
				T vEvent = Flow.FetchValue<T>(_event, reference);
				vEvent?.Raise(vEvent.InspectorRaiseValue);
			}
		}
		
		public override void StartListening(GraphStack stack)
		{
			base.StartListening(stack);

			Flow flow = Flow.New(stack.ToReference());
			T currentEvent = flow.GetValue<T>(_event);

			_eventRaisedHandler = (value) =>
			{
				flow.Invoke(trigger);
				_currentValue = value;
			};

			if (currentEvent)
			{
				currentEvent.Unregister(_eventRaisedHandler);
				currentEvent.Register(_eventRaisedHandler);				
			}
		}

		public override void StopListening(GraphStack stack)
		{
			base.StopListening(stack);

			T currentVoidEvent = Flow.FetchValue<T>(_event, stack.ToReference());
			currentVoidEvent?.Unregister(_eventRaisedHandler);
		}
		#endregion Public
		#endregion METHODS
	}
	
	[UnitCategory("Events/Atoms"), UnitShortTitle("AtomBaseVariable Event"), UnitTitle("AtomBaseVariable Event")]
	public class AtomBaseVariableEventUnit : AtomEventUnit<AtomBaseVariableEvent, AtomBaseVariable> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Bool Event"), UnitTitle("Atom Bool Event")]
	public class BoolEventUnit : AtomEventUnit<BoolEvent, bool> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("BoolPair Event"), UnitTitle("Atom BoolPair Event")]
	public class BoolPairEventUnit : AtomEventUnit<BoolPairEvent, BoolPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collider2D Event"), UnitTitle("Atom Collider2D Event")]
	public class Collider2DEventUnit : AtomEventUnit<Collider2DEvent, Collider2D> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collider2DPair Event"), UnitTitle("Atom Collider2DPair Event")]
	public class Collider2DPairEventUnit : AtomEventUnit<Collider2DPairEvent, Collider2DPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collider Event"), UnitTitle("Atom Collider Event")]
	public class ColliderEventUnit : AtomEventUnit<ColliderEvent, Collider> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("ColliderPair Event"), UnitTitle("Atom ColliderPair Event")]
	public class ColliderPairEventUnit : AtomEventUnit<ColliderPairEvent, ColliderPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collision2D Event"), UnitTitle("Atom Collision2D Event")]
	public class Collision2DEventUnit : AtomEventUnit<Collision2DEvent, Collision2D> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collision2DPair Event"), UnitTitle("Atom Collision2DPair Event")]
	public class Collision2DPairEventUnit : AtomEventUnit<Collision2DPairEvent, Collision2DPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Collision Event"), UnitTitle("Atom Collision Event")]
	public class CollisionEventUnit : AtomEventUnit<CollisionEvent, Collision> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("CollisionPair Event"), UnitTitle("Atom CollisionPair Event")]
	public class CollisionPairEventUnit : AtomEventUnit<CollisionPairEvent, CollisionPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Color Event"), UnitTitle("Atom Color Event")]
	public class ColorEventUnit : AtomEventUnit<ColorEvent, Color> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("ColorPair Event"), UnitTitle("Atom ColorPair Event")]
	public class ColorPairEventUnit : AtomEventUnit<ColorPairEvent, ColorPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Double Event"), UnitTitle("Atom Double Event")]
	public class DoubleEventUnit : AtomEventUnit<DoubleEvent, double> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("DoublePair Event"), UnitTitle("Atom DoublePair Event")]
	public class DoublePairEventUnit : AtomEventUnit<DoublePairEvent, DoublePair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Float Event"), UnitTitle("Atom Float Event")]
	public class FloatEventUnit : AtomEventUnit<FloatEvent, float> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("FloatPair Event"), UnitTitle("Atom FloatPair Event")]
	public class FloatPairEventUnit : AtomEventUnit<FloatPairEvent, FloatPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("GameObject Event"), UnitTitle("Atom GameObject Event")]
	public class GameObjectEventUnit : AtomEventUnit<GameObjectEvent, GameObject> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("GameObjectPair Event"), UnitTitle("Atom GameObjectPair Event")]
	public class GameObjectPairEventUnit : AtomEventUnit<GameObjectPairEvent, GameObjectPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Int Event"), UnitTitle("Atom Int Event")]
	public class IntEventUnit : AtomEventUnit<IntEvent, int> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("IntPair Event"), UnitTitle("Atom IntPair Event")]
	public class IntPairEventUnit : AtomEventUnit<IntPairEvent, IntPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Quaternion Event"), UnitTitle("Atom Quaternion Event")]
	public class QuaternionEventUnit : AtomEventUnit<QuaternionEvent, Quaternion> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("QuaternionPair Event"), UnitTitle("Atom QuaternionPair Event")]
	public class QuaternionPairEventUnit : AtomEventUnit<QuaternionPairEvent, QuaternionPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("String Event"), UnitTitle("Atom String Event")]
	public class StringEventUnit : AtomEventUnit<StringEvent, string> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("StringPair Event"), UnitTitle("Atom StringPair Event")]
	public class StringPairEventUnit : AtomEventUnit<StringPairEvent, StringPair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Vector2 Event"), UnitTitle("Atom Vector2 Event")]
	public class Vector2EventUnit : AtomEventUnit<Vector2Event, Vector2> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Vector2Pair Event"), UnitTitle("Atom Vector2Pair Event")]
	public class Vector2PairEventUnit : AtomEventUnit<Vector2PairEvent, Vector2Pair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Vector3 Event"), UnitTitle("Atom Vector3 Event")]
	public class Vector3EventUnit : AtomEventUnit<Vector3Event, Vector3> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Vector3Pair Event"), UnitTitle("Atom Vector3Pair Event")]
	public class Vector3PairEventUnit : AtomEventUnit<Vector3PairEvent, Vector3Pair> {}
	[UnitCategory("Events/Atoms"), UnitShortTitle("Void Event"), UnitTitle("Atom Void Event")]
	public class VoidEventUnit : AtomEventUnit<VoidEvent, UnityAtoms.Void> {}
}