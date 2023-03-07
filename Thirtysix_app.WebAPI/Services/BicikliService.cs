using AutoMapper;
using Thirtysix_app.Database;
using Thirtysix_app.Model;
using Thirtysix_app.Model.Requests;

namespace Thirtysix_app.WebAPI.Services
{
    public class BicikliService : IBicikliService
    {
        private readonly IMapper _mapper;
        private readonly eBicikliContext _context;

        public BicikliService(IMapper mapper, eBicikliContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<Model.Bicikli> Get(BicikliSearchRequest search)
        {
            var query=_context.Set<Database.Bicikli>().AsQueryable();
            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x=>x.Naziv.StartsWith(search.Naziv));
                var lista=query.ToList();
                return _mapper.Map<List<Model.Bicikli>>(lista);
            }
            else
            {
                var li = _context.Bicikli.ToList();
                return _mapper.Map<List<Model.Bicikli>>(li);
            }
                        
        }
    }
}
