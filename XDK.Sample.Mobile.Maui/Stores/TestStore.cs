using System;
using System.Threading.Tasks;
using XDK.Rest;
using XDK.Rest.Abstractions;
using XDK.Rest.Models;
using XDK.Sample.Mobile.Maui.Models;

namespace XDK.Sample.Mobile.Maui.Stores
{
    public class TestStore : BaseStore<TestModel, Guid>
    {
        public TestStore(RequestService requestService) : base(new StoreConfig<TestModel> { BaseUrl = "test" }, requestService) { }

        public async Task<TestModel> Test()
        {
            return await RequestService.MakeGet<TestModel>(GetRequestModel("test"));
        }
    }
}
