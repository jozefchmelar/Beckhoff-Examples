using Refit;
using System.Threading.Tasks;

namespace Plc
{

    public interface IAnalysis
    {
        [Post("/api/v1/")]
        [Headers("Accept: application / json", "Content-Type : application / json")]
        Task<Analysis> GetAnalysis([Body] Request data);
    }


}
