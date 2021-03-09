using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Container(Layout.Tabs)]
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stPrograms", "Plc", TypeComplexityEnum.Complex)]
	public partial class stPrograms : Vortex.Connector.IVortexObject, IstPrograms, IShadowstPrograms, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbEmail _EmailSender;
		[Container(Layout.Stack)]
		public fbEmail EmailSender
		{
			get
			{
				return _EmailSender;
			}
		}

		[Container(Layout.Stack)]
		IfbEmail IstPrograms.EmailSender
		{
			get
			{
				return EmailSender;
			}
		}

		[Container(Layout.Stack)]
		IShadowfbEmail IShadowstPrograms.EmailSender
		{
			get
			{
				return EmailSender;
			}
		}

		RemoteSorting _Sorting;
		[Container(Layout.Stack)]
		public RemoteSorting Sorting
		{
			get
			{
				return _Sorting;
			}
		}

		[Container(Layout.Stack)]
		IRemoteSorting IstPrograms.Sorting
		{
			get
			{
				return Sorting;
			}
		}

		[Container(Layout.Stack)]
		IShadowRemoteSorting IShadowstPrograms.Sorting
		{
			get
			{
				return Sorting;
			}
		}

		DataManager _Data;
		[Container(Layout.Stack)]
		public DataManager Data
		{
			get
			{
				return _Data;
			}
		}

		[Container(Layout.Stack)]
		IDataManager IstPrograms.Data
		{
			get
			{
				return Data;
			}
		}

		[Container(Layout.Stack)]
		IShadowDataManager IShadowstPrograms.Data
		{
			get
			{
				return Data;
			}
		}

		fbSms _TextMsg;
		[Container(Layout.Stack)]
		public fbSms TextMsg
		{
			get
			{
				return _TextMsg;
			}
		}

		[Container(Layout.Stack)]
		IfbSms IstPrograms.TextMsg
		{
			get
			{
				return TextMsg;
			}
		}

		[Container(Layout.Stack)]
		IShadowfbSms IShadowstPrograms.TextMsg
		{
			get
			{
				return TextMsg;
			}
		}

		fbRest _RestCall;
		[Container(Layout.Stack)]
		public fbRest RestCall
		{
			get
			{
				return _RestCall;
			}
		}

		[Container(Layout.Stack)]
		IfbRest IstPrograms.RestCall
		{
			get
			{
				return RestCall;
			}
		}

		[Container(Layout.Stack)]
		IShadowfbRest IShadowstPrograms.RestCall
		{
			get
			{
				return RestCall;
			}
		}

		public void LazyOnlineToShadow()
		{
			EmailSender.LazyOnlineToShadow();
			Sorting.LazyOnlineToShadow();
			Data.LazyOnlineToShadow();
			TextMsg.LazyOnlineToShadow();
			RestCall.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			EmailSender.LazyShadowToOnline();
			Sorting.LazyShadowToOnline();
			Data.LazyShadowToOnline();
			TextMsg.LazyShadowToOnline();
			RestCall.LazyShadowToOnline();
		}

		public PlainstPrograms CreatePlainerType()
		{
			var cloned = new PlainstPrograms();
			cloned.EmailSender = EmailSender.CreatePlainerType();
			cloned.Sorting = Sorting.CreatePlainerType();
			cloned.Data = Data.CreatePlainerType();
			cloned.TextMsg = TextMsg.CreatePlainerType();
			cloned.RestCall = RestCall.CreatePlainerType();
			return cloned;
		}

		protected PlainstPrograms CreatePlainerType(PlainstPrograms cloned)
		{
			cloned.EmailSender = EmailSender.CreatePlainerType();
			cloned.Sorting = Sorting.CreatePlainerType();
			cloned.Data = Data.CreatePlainerType();
			cloned.TextMsg = TextMsg.CreatePlainerType();
			cloned.RestCall = RestCall.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainstPrograms source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainstPrograms source)
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

		public void FlushOnlineToPlain(Plc.PlainstPrograms source)
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

		public stPrograms(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_EmailSender = new fbEmail(this, "", "EmailSender");
			_Sorting = new RemoteSorting(this, "", "Sorting");
			_Data = new DataManager(this, "", "Data");
			_TextMsg = new fbSms(this, "", "TextMsg");
			_RestCall = new fbRest(this, "", "RestCall");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stPrograms()
		{
			PexPreConstructorParameterless();
			_EmailSender = new fbEmail();
			_Sorting = new RemoteSorting();
			_Data = new DataManager();
			_TextMsg = new fbSms();
			_RestCall = new fbRest();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstPrograms
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstPrograms()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstPrograms : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.Stack)]
		IfbEmail EmailSender
		{
			get;
		}

		[Container(Layout.Stack)]
		IRemoteSorting Sorting
		{
			get;
		}

		[Container(Layout.Stack)]
		IDataManager Data
		{
			get;
		}

		[Container(Layout.Stack)]
		IfbSms TextMsg
		{
			get;
		}

		[Container(Layout.Stack)]
		IfbRest RestCall
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstPrograms CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainstPrograms source);
		void FlushOnlineToPlain(Plc.PlainstPrograms source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstPrograms : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.Stack)]
		IShadowfbEmail EmailSender
		{
			get;
		}

		[Container(Layout.Stack)]
		IShadowRemoteSorting Sorting
		{
			get;
		}

		[Container(Layout.Stack)]
		IShadowDataManager Data
		{
			get;
		}

		[Container(Layout.Stack)]
		IShadowfbSms TextMsg
		{
			get;
		}

		[Container(Layout.Stack)]
		IShadowfbRest RestCall
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainstPrograms CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainstPrograms source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstPrograms : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbEmail _EmailSender;
		[Container(Layout.Stack)]
		public PlainfbEmail EmailSender
		{
			get
			{
				return _EmailSender;
			}

			set
			{
				if (_EmailSender != value)
				{
					_EmailSender = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(EmailSender)));
				}
			}
		}

		PlainRemoteSorting _Sorting;
		[Container(Layout.Stack)]
		public PlainRemoteSorting Sorting
		{
			get
			{
				return _Sorting;
			}

			set
			{
				if (_Sorting != value)
				{
					_Sorting = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Sorting)));
				}
			}
		}

		PlainDataManager _Data;
		[Container(Layout.Stack)]
		public PlainDataManager Data
		{
			get
			{
				return _Data;
			}

			set
			{
				if (_Data != value)
				{
					_Data = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Data)));
				}
			}
		}

		PlainfbSms _TextMsg;
		[Container(Layout.Stack)]
		public PlainfbSms TextMsg
		{
			get
			{
				return _TextMsg;
			}

			set
			{
				if (_TextMsg != value)
				{
					_TextMsg = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TextMsg)));
				}
			}
		}

		PlainfbRest _RestCall;
		[Container(Layout.Stack)]
		public PlainfbRest RestCall
		{
			get
			{
				return _RestCall;
			}

			set
			{
				if (_RestCall != value)
				{
					_RestCall = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(RestCall)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.stPrograms target)
		{
			EmailSender.CopyPlainToCyclic(target.EmailSender);
			Sorting.CopyPlainToCyclic(target.Sorting);
			Data.CopyPlainToCyclic(target.Data);
			TextMsg.CopyPlainToCyclic(target.TextMsg);
			RestCall.CopyPlainToCyclic(target.RestCall);
		}

		public void CopyPlainToCyclic(Plc.IstPrograms target)
		{
			this.CopyPlainToCyclic((Plc.stPrograms)target);
		}

		public void CopyPlainToShadow(Plc.stPrograms target)
		{
			EmailSender.CopyPlainToShadow(target.EmailSender);
			Sorting.CopyPlainToShadow(target.Sorting);
			Data.CopyPlainToShadow(target.Data);
			TextMsg.CopyPlainToShadow(target.TextMsg);
			RestCall.CopyPlainToShadow(target.RestCall);
		}

		public void CopyPlainToShadow(Plc.IShadowstPrograms target)
		{
			this.CopyPlainToShadow((Plc.stPrograms)target);
		}

		public void CopyCyclicToPlain(Plc.stPrograms source)
		{
			EmailSender.CopyCyclicToPlain(source.EmailSender);
			Sorting.CopyCyclicToPlain(source.Sorting);
			Data.CopyCyclicToPlain(source.Data);
			TextMsg.CopyCyclicToPlain(source.TextMsg);
			RestCall.CopyCyclicToPlain(source.RestCall);
		}

		public void CopyCyclicToPlain(Plc.IstPrograms source)
		{
			this.CopyCyclicToPlain((Plc.stPrograms)source);
		}

		public void CopyShadowToPlain(Plc.stPrograms source)
		{
			EmailSender.CopyShadowToPlain(source.EmailSender);
			Sorting.CopyShadowToPlain(source.Sorting);
			Data.CopyShadowToPlain(source.Data);
			TextMsg.CopyShadowToPlain(source.TextMsg);
			RestCall.CopyShadowToPlain(source.RestCall);
		}

		public void CopyShadowToPlain(Plc.IShadowstPrograms source)
		{
			this.CopyShadowToPlain((Plc.stPrograms)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstPrograms()
		{
			_EmailSender = new PlainfbEmail();
			_Sorting = new PlainRemoteSorting();
			_Data = new PlainDataManager();
			_TextMsg = new PlainfbSms();
			_RestCall = new PlainfbRest();
		}
	}
}