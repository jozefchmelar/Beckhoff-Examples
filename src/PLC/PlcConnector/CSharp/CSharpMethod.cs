using System;
using Vortex.Connector;
using Vortex.Connector.ValueTypes;

namespace Plc
{
    public partial class CSharpMethod
    {
        public Action InvokeCsharpMethod { get; private set; }

        public void Initialize(Action action) => InvokeCsharpMethod = action;

        partial void PexConstructor(IVortexObject _, string _1, string _2)
        {
            InvokeRequested.Subscribe(OnInvokeRequested);
        }

        private void OnInvokeRequested(IValueTag sender, ValueChangedEventArgs args)
        {
            if (args.NewValue is false)
                return;
            CommandId.Cyclic = Guid.NewGuid().ToString();
            InvokeInProgress.Synchron = true;
            try
            {
                InvokeCsharpMethod();
                InvokeDone.Synchron = true;
                InvokeInProgress.Cyclic = false;
                InvokeRequested.Cyclic = false;
                InvokeError.Cyclic = true;
            }
            catch (Exception e)
            {
                InvokeRequested.Synchron = false;
                InvokeInProgress.Synchron = false;
                InvokeError.Synchron = true;
                InvokeDone.Synchron = true;
                ErrorMessage.Synchron = e.Message;
            }
        }
    }
}
