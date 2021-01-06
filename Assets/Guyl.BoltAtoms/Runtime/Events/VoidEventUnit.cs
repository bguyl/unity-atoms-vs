namespace Guyl.BoltAtoms.Runtime.Events
{
	using Bolt;
	using Ludiq;
	using UnityAtoms.BaseAtoms;
	using System;
	using UnityEngine;

	[UnitCategory("Events")]
	[UnitShortTitle("Void Event")]
	[UnitTitle("Void Event")]
	public class VoidEventUnit : EventUnit<EmptyEventArgs>
	{
		[DoNotSerialize] public ValueInput Event;

		private bool _shouldTrigger = false;
		private EventUnit<VoidEvent> m_eventUnitImplementation;

		protected override bool ShouldTrigger(Flow flow, EmptyEventArgs args)
		{
			if (_shouldTrigger)
			{
				_shouldTrigger = false;
				return true;
			}
			return false;
		}

		protected override bool register => true;

		protected string hookName => EventHooks.Update;

		public override EventHook GetHook(GraphReference reference) => new EventHook(hookName, reference.machine);

		private void OnEventRaised(UnityAtoms.Void a_obj)
		{
			_shouldTrigger = true;
		}

		protected override void Definition()
		{
			Event = ValueInput<VoidEvent>("", null);
			base.Definition();
		}

		public override void StartListening(GraphStack stack)
		{
			base.StartListening(stack);

			VoidEvent currentVoidEvent = Flow.FetchValue<VoidEvent>(Event, stack.ToReference());
			currentVoidEvent.Register(OnEventRaised);
		}

		public override void StopListening(GraphStack stack)
		{
			base.StopListening(stack);

			VoidEvent currentVoidEvent = Flow.FetchValue<VoidEvent>(Event, stack.ToReference());
			currentVoidEvent.Unregister(OnEventRaised);
		}
	}
}