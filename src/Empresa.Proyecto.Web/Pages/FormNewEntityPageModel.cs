using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Empresa.Proyecto.Web.Pages
{
    public class FormNewEntityPageModel<T>: PageModel where T : BaseEntity
    {
        private readonly IAsyncRepository<NewEntity> Repo;
        private readonly IAsyncRepository<SimpleEntity> SimpleEntityRepo;
        private readonly ILogger<FormNewEntityPageModel<T>> Logger;

        public FormNewEntityPageModel(ILogger<FormNewEntityPageModel<T>> logger, IAsyncRepository<NewEntity> repo, IAsyncRepository<SimpleEntity> simpleEntityRepo)
        {
            Repo = repo;
            SimpleEntityRepo = simpleEntityRepo;
            Logger = logger;
        }

        [BindProperty]
        public int IdOpcion { get; set; }
        public List<SelectListItem> Options { get; set; }

        public void OnGet()
        {
            var catalog = SimpleEntityRepo.ListAll();

            Options = catalog.Select(x =>
                                  new SelectListItem
                                  {
                                      Value = x.Id.ToString(),
                                      Text = x.Name
                                  }).ToList();
        }

        public async Task<IActionResult> OnPost(string nombre)
        {
            NewEntity registro = new NewEntity() {Created = DateTime.Now, Modified = DateTime.Now, Nombre = nombre, IdOpcion = IdOpcion};

            await Repo.AddAsync(registro);

            return RedirectToPage();
        }
    }
}
