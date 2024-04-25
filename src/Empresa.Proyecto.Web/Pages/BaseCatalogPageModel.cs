using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Empresa.Proyecto.Core.Specifications;

namespace Empresa.Proyecto.Web.Pages
{
    public class BaseCatalogPageModel<T>: PageModel where T : BaseEntity
    {
        private readonly IAsyncRepository<SimpleEntity> Repo;
        private readonly ILogger<BaseCatalogPageModel<T>> Logger;

        public IReadOnlyList<T> Entidades { get; set; } = null!;

        public BaseCatalogPageModel(ILogger<BaseCatalogPageModel<T>> logger, IAsyncRepository<SimpleEntity> repo)
        {
            Repo = repo;
            Logger = logger;
        }

        public async Task<JsonResult> OnPostCatalog()
        {
            var spec = new SimpleEntityAlphabeticalOrderSpecification();

            var catalog = await Repo.ListAsync(spec);
            return new JsonResult(new { data = catalog });
        }
    }
}
