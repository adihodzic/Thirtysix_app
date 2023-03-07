using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Thirtysix_app.Model.Requests;

namespace Thirtysix_app.WebAPI.Services
{
    public interface IBicikliService
    {
        List<Model.Bicikli> Get(BicikliSearchRequest search);
    }
}
