

using System.Threading.Tasks;
using edjCase.JsonRpc.Core;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;

namespace Nethereum.RPC
{

    ///<Summary>
       /// Sets the logging verbosity ceiling. Log messages with level up to and including the given level will be printed.
/// 
/// The verbosity of individual packages and source files can be raised using debug_vmodule.    
    ///</Summary>
    public class DebugVerbosity : RpcRequestResponseHandler<object>
        {
            public DebugVerbosity(IClient client) : base(client,ApiMethods.debug_verbosity.ToString()) { }

            public Task<object> SendRequestAsync(int level, object id = null)
            {
                return base.SendRequestAsync(id, level);
            }
            public RpcRequest BuildRequest(int level, object id = null)
            {
                return base.BuildRequest(id, level);
            }
        }

    }
