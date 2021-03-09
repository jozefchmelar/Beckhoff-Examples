using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbRest", "Plc", TypeComplexityEnum.Complex)]
	public partial class fbRest : Vortex.Connector.IVortexObject, IfbRest, IShadowfbRest, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString _ToAnalyse;
		public Vortex.Connector.ValueTypes.OnlinerString ToAnalyse
		{
			get
			{
				return _ToAnalyse;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbRest.ToAnalyse
		{
			get
			{
				return ToAnalyse;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbRest.ToAnalyse
		{
			get
			{
				return ToAnalyse;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _AnalysisResult;
		public Vortex.Connector.ValueTypes.OnlinerString AnalysisResult
		{
			get
			{
				return _AnalysisResult;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbRest.AnalysisResult
		{
			get
			{
				return AnalysisResult;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbRest.AnalysisResult
		{
			get
			{
				return AnalysisResult;
			}
		}

		CSharpMethod _RestCall;
		public CSharpMethod RestCall
		{
			get
			{
				return _RestCall;
			}
		}

		ICSharpMethod IfbRest.RestCall
		{
			get
			{
				return RestCall;
			}
		}

		IShadowCSharpMethod IShadowfbRest.RestCall
		{
			get
			{
				return RestCall;
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
		Vortex.Connector.ValueTypes.Online.IOnlineBool IfbRest.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		[RenderIgnore()]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowfbRest.StartSending
		{
			get
			{
				return StartSending;
			}
		}

		public void LazyOnlineToShadow()
		{
			ToAnalyse.Shadow = ToAnalyse.LastValue;
			AnalysisResult.Shadow = AnalysisResult.LastValue;
			RestCall.LazyOnlineToShadow();
			StartSending.Shadow = StartSending.LastValue;
		}

		public void LazyShadowToOnline()
		{
			ToAnalyse.Cyclic = ToAnalyse.Shadow;
			AnalysisResult.Cyclic = AnalysisResult.Shadow;
			RestCall.LazyShadowToOnline();
			StartSending.Cyclic = StartSending.Shadow;
		}

		public PlainfbRest CreatePlainerType()
		{
			var cloned = new PlainfbRest();
			cloned.RestCall = RestCall.CreatePlainerType();
			return cloned;
		}

		protected PlainfbRest CreatePlainerType(PlainfbRest cloned)
		{
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

		public void FlushPlainToOnline(Plc.PlainfbRest source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainfbRest source)
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

		public void FlushOnlineToPlain(Plc.PlainfbRest source)
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

		public fbRest(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_ToAnalyse = @Connector.Online.Adapter.CreateSTRING(this, "", "ToAnalyse");
			_AnalysisResult = @Connector.Online.Adapter.CreateSTRING(this, "", "AnalysisResult");
			_RestCall = new CSharpMethod(this, "Analyse sentiment", "RestCall");
			_RestCall.AttributeName = "Analyse sentiment";
			_StartSending = @Connector.Online.Adapter.CreateBOOL(this, "", "StartSending");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbRest()
		{
			PexPreConstructorParameterless();
			_ToAnalyse = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_AnalysisResult = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_RestCall = new CSharpMethod();
			_RestCall.AttributeName = "Analyse sentiment";
			_StartSending = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbRest
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbRest()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbRest : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString ToAnalyse
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString AnalysisResult
		{
			get;
		}

		ICSharpMethod RestCall
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

		Plc.PlainfbRest CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainfbRest source);
		void FlushOnlineToPlain(Plc.PlainfbRest source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbRest : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString ToAnalyse
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString AnalysisResult
		{
			get;
		}

		IShadowCSharpMethod RestCall
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

		Plc.PlainfbRest CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainfbRest source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbRest : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String _ToAnalyse;
		public System.String ToAnalyse
		{
			get
			{
				return _ToAnalyse;
			}

			set
			{
				if (_ToAnalyse != value)
				{
					_ToAnalyse = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ToAnalyse)));
				}
			}
		}

		System.String _AnalysisResult;
		public System.String AnalysisResult
		{
			get
			{
				return _AnalysisResult;
			}

			set
			{
				if (_AnalysisResult != value)
				{
					_AnalysisResult = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AnalysisResult)));
				}
			}
		}

		PlainCSharpMethod _RestCall;
		public PlainCSharpMethod RestCall
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

		public void CopyPlainToCyclic(Plc.fbRest target)
		{
			target.ToAnalyse.Cyclic = ToAnalyse;
			target.AnalysisResult.Cyclic = AnalysisResult;
			RestCall.CopyPlainToCyclic(target.RestCall);
			target.StartSending.Cyclic = StartSending;
		}

		public void CopyPlainToCyclic(Plc.IfbRest target)
		{
			this.CopyPlainToCyclic((Plc.fbRest)target);
		}

		public void CopyPlainToShadow(Plc.fbRest target)
		{
			target.ToAnalyse.Shadow = ToAnalyse;
			target.AnalysisResult.Shadow = AnalysisResult;
			RestCall.CopyPlainToShadow(target.RestCall);
			target.StartSending.Shadow = StartSending;
		}

		public void CopyPlainToShadow(Plc.IShadowfbRest target)
		{
			this.CopyPlainToShadow((Plc.fbRest)target);
		}

		public void CopyCyclicToPlain(Plc.fbRest source)
		{
			ToAnalyse = source.ToAnalyse.LastValue;
			AnalysisResult = source.AnalysisResult.LastValue;
			RestCall.CopyCyclicToPlain(source.RestCall);
			StartSending = source.StartSending.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IfbRest source)
		{
			this.CopyCyclicToPlain((Plc.fbRest)source);
		}

		public void CopyShadowToPlain(Plc.fbRest source)
		{
			ToAnalyse = source.ToAnalyse.Shadow;
			AnalysisResult = source.AnalysisResult.Shadow;
			RestCall.CopyShadowToPlain(source.RestCall);
			StartSending = source.StartSending.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowfbRest source)
		{
			this.CopyShadowToPlain((Plc.fbRest)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbRest()
		{
			_RestCall = new PlainCSharpMethod();
		}
	}
}