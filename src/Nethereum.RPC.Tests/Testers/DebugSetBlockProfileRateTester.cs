using System;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.DebugGeth;
using Xunit;

namespace Nethereum.RPC.Tests.Testers
{
    public class DebugSetBlockProfileRateTester : RPCRequestTester<object>, IRPCRequestTester
    {
        
        [Fact]
        public async void ShouldSetBlockProfileAndReturnNull()
        {
            var result = await ExecuteAsync(ClientFactory.GetClient());
            Assert.Null(result);
        }

        public override async Task<object> ExecuteAsync(IClient client)
        {
            var debugSetBlockProfileRate = new DebugSetBlockProfileRate(client);
            return await debugSetBlockProfileRate.SendRequestAsync(10);
        }

        public override Type GetRequestType()
        {
            return typeof(DebugSetBlockProfileRate);
        }
    }
}
        