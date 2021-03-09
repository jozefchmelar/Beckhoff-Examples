using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbEmail", "Plc", TypeComplexityEnum.Complex)]
	public partial class fbEmail : Vortex.Connector.IVortexObject, IfbEmail, IShadowfbEmail, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbEmail.Recipient
		{
			get
			{
				return Recipient;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbEmail.Recipient
		{
			get
			{
				return Recipient;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Subject;
		public Vortex.Connector.ValueTypes.OnlinerString Subject
		{
			get
			{
				return _Subject;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbEmail.Subject
		{
			get
			{
				return Subject;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbEmail.Subject
		{
			get
			{
				return Subject;
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbEmail.Content
		{
			get
			{
				return Content;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbEmail.Content
		{
			get
			{
				return Content;
			}
		}

		CSharpMethod _SendEmail;
		public CSharpMethod SendEmail
		{
			get
			{
				return _SendEmail;
			}
		}

		ICSharpMethod IfbEmail.SendEmail
		{
			get
			{
				return SendEmail;
			}
		}

		IShadowCSharpMethod IShadowfbEmail.SendEmail
		{
			get
			{
				return SendEmail;
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
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbEmail.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbEmail.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		public void LazyOnlineToShadow()
		{
			Recipient.Shadow = Recipient.LastValue;
			Subject.Shadow = Subject.LastValue;
			Content.Shadow = Content.LastValue;
			SendEmail.LazyOnlineToShadow();
			StartSending.Shadow = StartSending.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Recipient.Cyclic = Recipient.Shadow;
			Subject.Cyclic = Subject.Shadow;
			Content.Cyclic = Content.Shadow;
			SendEmail.LazyShadowToOnline();
			StartSending.Cyclic = StartSending.Shadow;
		}

		public PlainfbEmail CreatePlainerType()
		{
			var cloned = new PlainfbEmail();
			cloned.SendEmail = SendEmail.CreatePlainerType();
			return cloned;
		}

		protected PlainfbEmail CreatePlainerType(PlainfbEmail cloned)
		{
			cloned.SendEmail = SendEmail.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainfbEmail source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainfbEmail source)
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

		public void FlushOnlineToPlain(Plc.PlainfbEmail source)
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

		public fbEmail(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Subject = @Connector.Online.Adapter.CreateSTRING(this, "", "Subject");
			_Content = @Connector.Online.Adapter.CreateSTRING(this, "", "Content");
			_SendEmail = new CSharpMethod(this, "Send email", "SendEmail");
			_SendEmail.AttributeName = "Send email";
			_StartSending = @Connector.Online.Adapter.CreateBOOL(this, "", "StartSending");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbEmail()
		{
			PexPreConstructorParameterless();
			_Recipient = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Subject = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Content = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_SendEmail = new CSharpMethod();
			_SendEmail.AttributeName = "Send email";
			_StartSending = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbEmail
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbEmail()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbEmail : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString Recipient
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString Subject
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString Content
		{
			get;
		}

		ICSharpMethod SendEmail
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

		Plc.PlainfbEmail CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainfbEmail source);
		void FlushOnlineToPlain(Plc.PlainfbEmail source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbEmail : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString Recipient
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString Subject
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString Content
		{
			get;
		}

		IShadowCSharpMethod SendEmail
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

		Plc.PlainfbEmail CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainfbEmail source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbEmail : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
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

		System.String _Subject;
		public System.String Subject
		{
			get
			{
				return _Subject;
			}

			set
			{
				if (_Subject != value)
				{
					_Subject = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Subject)));
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

		PlainCSharpMethod _SendEmail;
		public PlainCSharpMethod SendEmail
		{
			get
			{
				return _SendEmail;
			}

			set
			{
				if (_SendEmail != value)
				{
					_SendEmail = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SendEmail)));
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

		public void CopyPlainToCyclic(Plc.fbEmail target)
		{
			target.Recipient.Cyclic = Recipient;
			target.Subject.Cyclic = Subject;
			target.Content.Cyclic = Content;
			SendEmail.CopyPlainToCyclic(target.SendEmail);
			target.StartSending.Cyclic = StartSending;
		}

		public void CopyPlainToCyclic(Plc.IfbEmail target)
		{
			this.CopyPlainToCyclic((Plc.fbEmail)target);
		}

		public void CopyPlainToShadow(Plc.fbEmail target)
		{
			target.Recipient.Shadow = Recipient;
			target.Subject.Shadow = Subject;
			target.Content.Shadow = Content;
			SendEmail.CopyPlainToShadow(target.SendEmail);
			target.StartSending.Shadow = StartSending;
		}

		public void CopyPlainToShadow(Plc.IShadowfbEmail target)
		{
			this.CopyPlainToShadow((Plc.fbEmail)target);
		}

		public void CopyCyclicToPlain(Plc.fbEmail source)
		{
			Recipient = source.Recipient.LastValue;
			Subject = source.Subject.LastValue;
			Content = source.Content.LastValue;
			SendEmail.CopyCyclicToPlain(source.SendEmail);
			StartSending = source.StartSending.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IfbEmail source)
		{
			this.CopyCyclicToPlain((Plc.fbEmail)source);
		}

		public void CopyShadowToPlain(Plc.fbEmail source)
		{
			Recipient = source.Recipient.Shadow;
			Subject = source.Subject.Shadow;
			Content = source.Content.Shadow;
			SendEmail.CopyShadowToPlain(source.SendEmail);
			StartSending = source.StartSending.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowfbEmail source)
		{
			this.CopyShadowToPlain((Plc.fbEmail)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbEmail()
		{
			_SendEmail = new PlainCSharpMethod();
		}
	}
}