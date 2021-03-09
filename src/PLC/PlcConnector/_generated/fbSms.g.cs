using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbSms", "Plc", TypeComplexityEnum.Complex)]
	public partial class fbSms : Vortex.Connector.IVortexObject, IfbSms, IShadowfbSms, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerString _Recipient;
		public Vortex.Connector.ValueTypes.OnlinerString Recipient
		{
			get
			{
				return _Recipient;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbSms.Recipient
		{
			get
			{
				return Recipient;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbSms.Recipient
		{
			get
			{
				return Recipient;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Content;
		public Vortex.Connector.ValueTypes.OnlinerString Content
		{
			get
			{
				return _Content;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbSms.Content
		{
			get
			{
				return Content;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbSms.Content
		{
			get
			{
				return Content;
			}
		}

		CSharpMethod _SendTextMessage;
		public CSharpMethod SendTextMessage
		{
			get
			{
				return _SendTextMessage;
			}
		}

		ICSharpMethod IfbSms.SendTextMessage
		{
			get
			{
				return SendTextMessage;
			}
		}

		IShadowCSharpMethod IShadowfbSms.SendTextMessage
		{
			get
			{
				return SendTextMessage;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _StartSending;
		[RenderIgnore()]
		public Vortex.Connector.ValueTypes.OnlinerBool StartSending
		{
			get
			{
				return _StartSending;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbSms.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbSms.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		public void LazyOnlineToShadow()
		{
			Recipient.Shadow = Recipient.LastValue;
			Content.Shadow = Content.LastValue;
			SendTextMessage.LazyOnlineToShadow();
			StartSending.Shadow = StartSending.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Recipient.Cyclic = Recipient.Shadow;
			Content.Cyclic = Content.Shadow;
			SendTextMessage.LazyShadowToOnline();
			StartSending.Cyclic = StartSending.Shadow;
		}

		public PlainfbSms CreatePlainerType()
		{
			var cloned = new PlainfbSms();
			cloned.SendTextMessage = SendTextMessage.CreatePlainerType();
			return cloned;
		}

		protected PlainfbSms CreatePlainerType(PlainfbSms cloned)
		{
			cloned.SendTextMessage = SendTextMessage.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainfbSms source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainfbSms source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainfbSms source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public fbSms(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Recipient = @Connector.Online.Adapter.CreateSTRING(this, "", "Recipient");
			_Content = @Connector.Online.Adapter.CreateSTRING(this, "", "Content");
			_SendTextMessage = new CSharpMethod(this, "Send text message", "SendTextMessage");
			_SendTextMessage.AttributeName = "Send text message";
			_StartSending = @Connector.Online.Adapter.CreateBOOL(this, "", "StartSending");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbSms()
		{
			PexPreConstructorParameterless();
			_Recipient = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Content = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_SendTextMessage = new CSharpMethod();
			_SendTextMessage.AttributeName = "Send text message";
			_StartSending = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbSms
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbSms()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbSms : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString Recipient
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString Content
		{
			get;
		}

		ICSharpMethod SendTextMessage
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Online.IOnlineBool StartSending
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbSms CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainfbSms source);
		void FlushOnlineToPlain(Plc.PlainfbSms source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbSms : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString Recipient
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString Content
		{
			get;
		}

		IShadowCSharpMethod SendTextMessage
		{
			get;
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool StartSending
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbSms CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainfbSms source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbSms : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _Recipient;
		public System.String Recipient
		{
			get
			{
				return _Recipient;
			}

			set
			{
				if (_Recipient != value)
				{
					_Recipient = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Recipient)));
				}
			}
		}

		System.String _Content;
		public System.String Content
		{
			get
			{
				return _Content;
			}

			set
			{
				if (_Content != value)
				{
					_Content = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Content)));
				}
			}
		}

		PlainCSharpMethod _SendTextMessage;
		public PlainCSharpMethod SendTextMessage
		{
			get
			{
				return _SendTextMessage;
			}

			set
			{
				if (_SendTextMessage != value)
				{
					_SendTextMessage = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SendTextMessage)));
				}
			}
		}

		System.Boolean _StartSending;
		[RenderIgnore()]
		public System.Boolean StartSending
		{
			get
			{
				return _StartSending;
			}

			set
			{
				if (_StartSending != value)
				{
					_StartSending = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(StartSending)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.fbSms target)
		{
			target.Recipient.Cyclic = Recipient;
			target.Content.Cyclic = Content;
			SendTextMessage.CopyPlainToCyclic(target.SendTextMessage);
			target.StartSending.Cyclic = StartSending;
		}

		public void CopyPlainToCyclic(Plc.IfbSms target)
		{
			this.CopyPlainToCyclic((Plc.fbSms)target);
		}

		public void CopyPlainToShadow(Plc.fbSms target)
		{
			target.Recipient.Shadow = Recipient;
			target.Content.Shadow = Content;
			SendTextMessage.CopyPlainToShadow(target.SendTextMessage);
			target.StartSending.Shadow = StartSending;
		}

		public void CopyPlainToShadow(Plc.IShadowfbSms target)
		{
			this.CopyPlainToShadow((Plc.fbSms)target);
		}

		public void CopyCyclicToPlain(Plc.fbSms source)
		{
			Recipient = source.Recipient.LastValue;
			Content = source.Content.LastValue;
			SendTextMessage.CopyCyclicToPlain(source.SendTextMessage);
			StartSending = source.StartSending.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IfbSms source)
		{
			this.CopyCyclicToPlain((Plc.fbSms)source);
		}

		public void CopyShadowToPlain(Plc.fbSms source)
		{
			Recipient = source.Recipient.Shadow;
			Content = source.Content.Shadow;
			SendTextMessage.CopyShadowToPlain(source.SendTextMessage);
			StartSending = source.StartSending.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowfbSms source)
		{
			this.CopyShadowToPlain((Plc.fbSms)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbSms()
		{
			_SendTextMessage = new PlainCSharpMethod();
		}
	}
}