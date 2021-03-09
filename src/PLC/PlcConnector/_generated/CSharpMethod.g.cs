using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "CSharpMethod", "Plc", TypeComplexityEnum.Complex)]
	public partial class CSharpMethod : Vortex.Connector.IVortexObject, ICSharpMethod, IShadowCSharpMethod, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _InvokeRequested;
		public Vortex.Connector.ValueTypes.OnlinerBool InvokeRequested
		{
			get
			{
				return _InvokeRequested;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICSharpMethod.InvokeRequested
		{
			get
			{
				return InvokeRequested;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCSharpMethod.InvokeRequested
		{
			get
			{
				return InvokeRequested;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _InvokeInProgress;
		public Vortex.Connector.ValueTypes.OnlinerBool InvokeInProgress
		{
			get
			{
				return _InvokeInProgress;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICSharpMethod.InvokeInProgress
		{
			get
			{
				return InvokeInProgress;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCSharpMethod.InvokeInProgress
		{
			get
			{
				return InvokeInProgress;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _InvokeDone;
		public Vortex.Connector.ValueTypes.OnlinerBool InvokeDone
		{
			get
			{
				return _InvokeDone;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICSharpMethod.InvokeDone
		{
			get
			{
				return InvokeDone;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCSharpMethod.InvokeDone
		{
			get
			{
				return InvokeDone;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _InvokeError;
		public Vortex.Connector.ValueTypes.OnlinerBool InvokeError
		{
			get
			{
				return _InvokeError;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICSharpMethod.InvokeError
		{
			get
			{
				return InvokeError;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCSharpMethod.InvokeError
		{
			get
			{
				return InvokeError;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _ErrorMessage;
		public Vortex.Connector.ValueTypes.OnlinerString ErrorMessage
		{
			get
			{
				return _ErrorMessage;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString ICSharpMethod.ErrorMessage
		{
			get
			{
				return ErrorMessage;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowCSharpMethod.ErrorMessage
		{
			get
			{
				return ErrorMessage;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _CommandId;
		public Vortex.Connector.ValueTypes.OnlinerString CommandId
		{
			get
			{
				return _CommandId;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString ICSharpMethod.CommandId
		{
			get
			{
				return CommandId;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowCSharpMethod.CommandId
		{
			get
			{
				return CommandId;
			}
		}

		public void LazyOnlineToShadow()
		{
			InvokeRequested.Shadow = InvokeRequested.LastValue;
			InvokeInProgress.Shadow = InvokeInProgress.LastValue;
			InvokeDone.Shadow = InvokeDone.LastValue;
			InvokeError.Shadow = InvokeError.LastValue;
			ErrorMessage.Shadow = ErrorMessage.LastValue;
			CommandId.Shadow = CommandId.LastValue;
		}

		public void LazyShadowToOnline()
		{
			InvokeRequested.Cyclic = InvokeRequested.Shadow;
			InvokeInProgress.Cyclic = InvokeInProgress.Shadow;
			InvokeDone.Cyclic = InvokeDone.Shadow;
			InvokeError.Cyclic = InvokeError.Shadow;
			ErrorMessage.Cyclic = ErrorMessage.Shadow;
			CommandId.Cyclic = CommandId.Shadow;
		}

		public PlainCSharpMethod CreatePlainerType()
		{
			var cloned = new PlainCSharpMethod();
			return cloned;
		}

		protected PlainCSharpMethod CreatePlainerType(PlainCSharpMethod cloned)
		{
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

		public void FlushPlainToOnline(Plc.PlainCSharpMethod source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainCSharpMethod source)
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

		public void FlushOnlineToPlain(Plc.PlainCSharpMethod source)
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

		public CSharpMethod(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_InvokeRequested = @Connector.Online.Adapter.CreateBOOL(this, "", "InvokeRequested");
			_InvokeInProgress = @Connector.Online.Adapter.CreateBOOL(this, "", "InvokeInProgress");
			_InvokeDone = @Connector.Online.Adapter.CreateBOOL(this, "", "InvokeDone");
			_InvokeError = @Connector.Online.Adapter.CreateBOOL(this, "", "InvokeError");
			_ErrorMessage = @Connector.Online.Adapter.CreateSTRING(this, "", "ErrorMessage");
			_CommandId = @Connector.Online.Adapter.CreateSTRING(this, "", "CommandId");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public CSharpMethod()
		{
			PexPreConstructorParameterless();
			_InvokeRequested = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_InvokeInProgress = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_InvokeDone = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_InvokeError = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_ErrorMessage = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_CommandId = Vortex.Connector.IConnectorFactory.CreateSTRING();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcCSharpMethod
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcCSharpMethod()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ICSharpMethod : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool InvokeRequested
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool InvokeInProgress
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool InvokeDone
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool InvokeError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString ErrorMessage
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString CommandId
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainCSharpMethod CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainCSharpMethod source);
		void FlushOnlineToPlain(Plc.PlainCSharpMethod source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowCSharpMethod : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool InvokeRequested
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool InvokeInProgress
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool InvokeDone
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool InvokeError
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString ErrorMessage
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString CommandId
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainCSharpMethod CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainCSharpMethod source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCSharpMethod : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _InvokeRequested;
		public System.Boolean InvokeRequested
		{
			get
			{
				return _InvokeRequested;
			}

			set
			{
				if (_InvokeRequested != value)
				{
					_InvokeRequested = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InvokeRequested)));
				}
			}
		}

		System.Boolean _InvokeInProgress;
		public System.Boolean InvokeInProgress
		{
			get
			{
				return _InvokeInProgress;
			}

			set
			{
				if (_InvokeInProgress != value)
				{
					_InvokeInProgress = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InvokeInProgress)));
				}
			}
		}

		System.Boolean _InvokeDone;
		public System.Boolean InvokeDone
		{
			get
			{
				return _InvokeDone;
			}

			set
			{
				if (_InvokeDone != value)
				{
					_InvokeDone = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InvokeDone)));
				}
			}
		}

		System.Boolean _InvokeError;
		public System.Boolean InvokeError
		{
			get
			{
				return _InvokeError;
			}

			set
			{
				if (_InvokeError != value)
				{
					_InvokeError = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InvokeError)));
				}
			}
		}

		System.String _ErrorMessage;
		public System.String ErrorMessage
		{
			get
			{
				return _ErrorMessage;
			}

			set
			{
				if (_ErrorMessage != value)
				{
					_ErrorMessage = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ErrorMessage)));
				}
			}
		}

		System.String _CommandId;
		public System.String CommandId
		{
			get
			{
				return _CommandId;
			}

			set
			{
				if (_CommandId != value)
				{
					_CommandId = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(CommandId)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.CSharpMethod target)
		{
			target.InvokeRequested.Cyclic = InvokeRequested;
			target.InvokeInProgress.Cyclic = InvokeInProgress;
			target.InvokeDone.Cyclic = InvokeDone;
			target.InvokeError.Cyclic = InvokeError;
			target.ErrorMessage.Cyclic = ErrorMessage;
			target.CommandId.Cyclic = CommandId;
		}

		public void CopyPlainToCyclic(Plc.ICSharpMethod target)
		{
			this.CopyPlainToCyclic((Plc.CSharpMethod)target);
		}

		public void CopyPlainToShadow(Plc.CSharpMethod target)
		{
			target.InvokeRequested.Shadow = InvokeRequested;
			target.InvokeInProgress.Shadow = InvokeInProgress;
			target.InvokeDone.Shadow = InvokeDone;
			target.InvokeError.Shadow = InvokeError;
			target.ErrorMessage.Shadow = ErrorMessage;
			target.CommandId.Shadow = CommandId;
		}

		public void CopyPlainToShadow(Plc.IShadowCSharpMethod target)
		{
			this.CopyPlainToShadow((Plc.CSharpMethod)target);
		}

		public void CopyCyclicToPlain(Plc.CSharpMethod source)
		{
			InvokeRequested = source.InvokeRequested.LastValue;
			InvokeInProgress = source.InvokeInProgress.LastValue;
			InvokeDone = source.InvokeDone.LastValue;
			InvokeError = source.InvokeError.LastValue;
			ErrorMessage = source.ErrorMessage.LastValue;
			CommandId = source.CommandId.LastValue;
		}

		public void CopyCyclicToPlain(Plc.ICSharpMethod source)
		{
			this.CopyCyclicToPlain((Plc.CSharpMethod)source);
		}

		public void CopyShadowToPlain(Plc.CSharpMethod source)
		{
			InvokeRequested = source.InvokeRequested.Shadow;
			InvokeInProgress = source.InvokeInProgress.Shadow;
			InvokeDone = source.InvokeDone.Shadow;
			InvokeError = source.InvokeError.Shadow;
			ErrorMessage = source.ErrorMessage.Shadow;
			CommandId = source.CommandId.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowCSharpMethod source)
		{
			this.CopyShadowToPlain((Plc.CSharpMethod)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainCSharpMethod()
		{
		}
	}
}