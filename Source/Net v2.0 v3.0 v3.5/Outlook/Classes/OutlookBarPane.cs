//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OutlookBarPane_BeforeNavigateEventHandler(NetOffice.OutlookApi.OutlookBarShortcut Shortcut, ref bool Cancel);
	public delegate void OutlookBarPane_BeforeGroupSwitchEventHandler(NetOffice.OutlookApi.OutlookBarGroup ToGroup, ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OutlookBarPane SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OutlookBarPane : _OutlookBarPane, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OutlookBarPaneEvents_SinkHelper _outlookBarPaneEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public OutlookBarPane(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OutlookBarPane(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OutlookBarPane(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OutlookBarPane()
		{
			CreateFromProgId("Outlook.OutlookBarPane");
		}
		
		/// <param name="progId">progId</param>
		public OutlookBarPane(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OutlookBarPaneEvents_SinkHelper.Id);


			if(OutlookBarPaneEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_outlookBarPaneEvents_SinkHelper = new OutlookBarPaneEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event OutlookBarPane_BeforeNavigateEventHandler _BeforeNavigateEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event OutlookBarPane_BeforeNavigateEventHandler BeforeNavigateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeNavigateEvent += value;
			}
			remove
			{
				_BeforeNavigateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event OutlookBarPane_BeforeGroupSwitchEventHandler _BeforeGroupSwitchEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event OutlookBarPane_BeforeGroupSwitchEventHandler BeforeGroupSwitchEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeGroupSwitchEvent += value;
			}
			remove
			{
				_BeforeGroupSwitchEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _outlookBarPaneEvents_SinkHelper)
			{
				_outlookBarPaneEvents_SinkHelper.Dispose();
				_outlookBarPaneEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}